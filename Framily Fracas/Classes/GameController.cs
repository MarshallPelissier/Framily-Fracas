using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace Framily_Fracas
{    public struct FMAnswer
    {
        public FMAnswer(string t, int p, int pl)
        {
            text = t;
            points = p;
            place = pl;
        }

        public String text { get; set; }
        public int points { get; set; }
        public int place { get; set; }

    }

    public enum Year
    {
        y06,
        y16,
        y17,
        y18,
        y19,
        y20,
        no
    }

    public class GameController
    {

        private Question question;

        private SurveyData answers1;
        private SurveyData answers4;
        private SurveyData answers5;
        private SurveyData answers6;
        private SurveyData answers7;
        private SurveyData answers8;

        public String framily1;
        public String framily2;
        public List<String> fram1 = new List<string>();
        public List<String> fram2 = new List<string>();

        public bool turn = true;

        public int round = 0;
        public int[] rounds = { 1, 1, 2, 2, 3 };

        public int FramPoints1 = 0;
        public int FramPoints2 = 0;

        private SurveyBoard surveyBoard;
        private Controller controller;

        public int strikes = 0;

        private bool init = false;

        public bool playFM = false;
        public List<Question> fastMoney = new List<Question>();
        public List<FMAnswer> FM1 = new List<FMAnswer>();
        public List<FMAnswer> FM2 = new List<FMAnswer>();

        public Year currentYear = Year.no;

        public SoundPlayer Ding = new SoundPlayer("..\\..\\Sounds\\Ding.wav");
        public SoundPlayer Theme = new SoundPlayer("..\\..\\Sounds\\Theme.wav");
        public SoundPlayer Strike = new SoundPlayer("..\\..\\Sounds\\Strike.wav");


        public void StartNewGame()
        {
            playFM = false;
            GetNewQuestion();
            surveyBoard.UpdateNames();
            surveyBoard.UpdateScores();
            surveyBoard.UpdateTeam(false);
        }

        public void GetNewQuestion()
        {
            SaveSurveys();
            strikes = 0;
            question = new Question();
            Random rng = new Random();
            int num = rng.Next(5)+1;
            switch (num)
            {
                case 1:
                    question = answers4.GetNewQuestion();
                    break;

                case 2:
                    question = answers5.GetNewQuestion();
                    break;

                case 3:
                    question = answers6.GetNewQuestion();
                    break;

                case 4:
                    question = answers7.GetNewQuestion();
                    break;

                case 5:
                    question = answers8.GetNewQuestion();
                    break;

                default:
                    question = answers1.GetNewQuestion();
                    break;
            }

            updateBoards();

            return ;
        }

        public Question FindFMQuestion()
        {
            Question q = new Question();

            Random rng = new Random();
            int r = rng.Next(4);
            if (r == 0 || r == 1)
            {
                q = answers4.GetNewQuestion(true);
            }
            else if (r == 2)
            {
                q = answers5.GetNewQuestion(true);
            }
            else
            {
                q = answers6.GetNewQuestion(true);
            }

            return q;
        }

        private void GetFastMoney()
        {
            fastMoney.Clear();
            Random rng = new Random();
            Question questionFM;
            for (int i = 0; i < 5; i++)
            {
                //questionFM = new Question();
                //int r = rng.Next(4);
                //if (r == 0 || r == 1)
                //{
                //    questionFM = answers4.GetNewQuestion(true);
                //}
                //else if (r == 2)
                //{
                //    questionFM = answers5.GetNewQuestion(true);
                //}
                //else
                //{
                //    questionFM = answers6.GetNewQuestion(true);
                //}

                questionFM = FindFMQuestion();
                fastMoney.Add(questionFM);
                questionFM = null;
                Thread.Sleep(50);
            }
        }

        private void updateBoards()
        {
            surveyBoard.UpdateQuestion(question);
            controller.UpdateQuestion(question);        
        }

        public void UpdateAnswer(Answer a)
        {
            surveyBoard.UpdateAnswers(a);
        }

        public void UpdateAnswer(FMAnswer a)
        {
            surveyBoard.UpdateAnswers(a);
        }

        public void UpdateTeam(bool t)
        {
            turn = t;
            surveyBoard.UpdateTeam();
        }

        public void NextRound(bool framily)
        {
            if (round > rounds.Length - 1)
            {

                DialogResult dialogResult = MessageBox.Show("Play Fast Money?", "Fast Money", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    playFM = true;
                    StartFastMoney();
                }
                else
                {
                    surveyBoard.NewSetup();
                    round = 0;
                    FramPoints1 = 0;
                    FramPoints2 = 0;
                }
            }
            else
            {
                if (framily)
                {
                    FramPoints1 += question.points * rounds[round];
                }
                else
                {
                    FramPoints2 += question.points * rounds[round];
                }
            }
            
            round++;

            surveyBoard.UpdateScores();
            surveyBoard.UpdateTeam(false);
            GetNewQuestion();
        }

        public void StartFastMoney()
        {
            GetFastMoney();
            surveyBoard.StartFastMoney();
            controller.StartFastMoney();
        }

        public void InitializeSurveys()
        {
            string suffix = getSuffix(currentYear);

            string jpath = "..\\..\\Surveys\\" + suffix + ".json";
            string tpath = "..\\..\\Surveys\\" + suffix + "_";

            surveyBoard = Program.sb;
            controller = Program.c;

            if (File.Exists(jpath))
            {
                var _jsonSettings = new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    ObjectCreationHandling = ObjectCreationHandling.Auto
                };

                string json = File.ReadAllText(jpath);
                SurveyContainer surveys = JsonConvert.DeserializeObject<SurveyContainer>(json, _jsonSettings);
                answers1 = surveys.answers1;
                answers4 = surveys.answers4;
                answers5 = surveys.answers5;
                answers6 = surveys.answers6;
                answers7 = surveys.answers7;
                answers8 = surveys.answers8;
            }

            else
            {
                int[] files = { 1, 4, 5, 6, 7, 8 };
                string[] lines;
                string[] line;
                string t;
                int p;
                SurveyData surveyData;
                Question question = new Question();

                int answerID = 1;
                foreach (int file in files)
                {
                    surveyData = new SurveyData();
                    lines = System.IO.File.ReadAllLines(tpath + file.ToString() + ".txt");

                    int count = 0;
                    //for ( count < lines.Length; count++)
                    while (count < lines.Length)
                    {
                        for (int i = 0; i < file + 1; i++)
                        {
                            line = lines[count].Split('~');
                            t = line[0];
                            p = int.Parse(line[1]);

                            if (i == 0)
                            {
                                question = new Question();
                                question.text = t;
                                question.maxPoint = p;
                            }
                            else
                            {
                                question.answers.Add(new Answer(t, p, answerID));
                                answerID++;
                            }
                            count++;
                        }
                        question.SortAnswers();
                        surveyData.AddNewQuestion(question);
                    }

                    switch (file)
                    {
                        case 1:
                            answers1 = surveyData;
                            break;

                        case 4:
                            answers4 = surveyData;
                            break;

                        case 5:
                            answers5 = surveyData;
                            break;

                        case 6:
                            answers6 = surveyData;
                            break;

                        case 7:
                            answers7 = surveyData;
                            break;

                        case 8:
                            answers8 = surveyData;
                            break;
                    }
                }
            }

            StartNewGame();
        }

        public void SaveSurveys()
        {
            SurveyContainer surveys = new SurveyContainer();
            surveys.answers1 = answers1;
            surveys.answers4 = answers4;
            surveys.answers5 = answers5;
            surveys.answers6 = answers6;
            surveys.answers7 = answers7;
            surveys.answers8 = answers8;

            string suffix = getSuffix(currentYear);
            string jpath = "..\\..\\Surveys\\" + suffix + ".json";

            var _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            string jsonString = JsonConvert.SerializeObject(surveys, Formatting.Indented, _jsonSettings);
            File.WriteAllText(jpath, jsonString);
        }

        private string getSuffix (Year year)
        {
            string suffix = Enum.GetName(typeof(Year), currentYear);
            return suffix.Replace("y", string.Empty);
        }

        public void LoadSounds()
        {
            Ding.Load();
            Theme.Load();
            Strike.Load();
        }
    }
}
