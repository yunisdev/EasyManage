using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;


namespace EasyManage
{
    public partial class MainUI : MetroFramework.Forms.MetroForm
    {
        #region Loading modules
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        #endregion




        public SoundPlayer hello_sound = new SoundPlayer(@"sounds\hello.wav");
        public SoundPlayer how_are_you_sound = new SoundPlayer(@"mm.wav");
        public SoundPlayer my_name_is_easy_sound = new SoundPlayer(@"mm.wav");
        public SoundPlayer years_old_sound = new SoundPlayer(@"mm.wav");
        



        public MainUI()
        {

            InitializeComponent();


            #region splash
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(10);
            }
            t.Abort();
            #endregion

        }
        void Loading()
        {
            splash f = new splash();
            Application.Run(f);
        }

        public static string capitalize_string(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.  
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public string Easy_Mood = "Good";
        public string Easy_question_status;


        public static string answer_why(string status)
        {
            switch (status)
            {
                case "what is your name":
                    return "Because Yunis named me like this.";
                    
                case "how are you Good":
                    return "Because i have a user like you :)";
                    
                case "how are you Bad":
                    return "Because you humiliated me!!!";
                    
                case "swear":
                    return "You are swearing!!!";

                case "hello":
                    return "Are you joking with me?? >:(";
                    
                default:
                    return "What do you mean?";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            pause.Enabled = false;
            this.WindowState = FormWindowState.Normal;

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Progress.Value = 0;
            #region Recognizing Word
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            pause.Enabled = true;
            clist.Add(new string[] {

                #region Conversational

                "hello",
                "how are you",
                "why",
                "what is you name",
                "how old are you",
                "you are bad",
                "you\'re bad",

                

                #endregion
                
                #region Functional

                "Chrome",
                "minimize",
                "maximize",
                "chrome",
                "Note",
                "note",
                "manage",
                "Manage",
                "shutdown",
                "calculator",
                "calculate",
                "youtube",
                "Youtube",
                "You tube",
                "close",

                #endregion
                
                #region Swear

                "shit",
                "",
                "",
                "",


                #endregion

            });
            #region Organizing Speech
            Grammar gr = new Grammar(new GrammarBuilder(clist));
            Progress.Value = 20;
            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += Sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            Thread.Sleep(1500);
            Progress.Value = 75;
        }
        #endregion
        #endregion
        public int aaa = 0;
        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            Progress.Value = 100;
            if (aaa == 1)
            {
                return;
            }

            switch (e.Result.Text.ToString())
            {


                #region Conversational cases

                case "why":
                    txtContents.Text = answer_why(Easy_question_status);
                    break;

                case "hello":
                    txtContents.Text = "Hello " + capitalize_string(Environment.UserName);
                    Easy_question_status = "hello";
                    break;

                case "how are you":
                    txtContents.Text = $"{Easy_Mood}.";
                    Easy_question_status = $"how are you {Easy_Mood}";
                    break;

                case "how old are you":
                    txtContents.Text = $"I am a robot i have not age. I am young everytime.";
                    break;

                case "what\'s you name":
                case "what is you name":
                    txtContents.Text = "My name is Easybyte";
                    Easy_question_status = "what is you name";
                    break;

                case "you are bad":
                case "you\'re bad":
                    Easy_Mood = "Bad";
                    txtContents.Text = "Why??";
                    break;

                #endregion

                #region Functional cases

                case "shutdown":
                    Process.Start("shutdown", "/s /t 0");
                    break;

                case "calculate":
                case "calculator":
                    Process.Start("calc.exe");
                    break;

                case "youtube":
                case "You tube":
                case "Youtube":
                    Process.Start("chrome","youtube.com");
                    break;

                case "minimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;

                case "maximize":
                    this.WindowState = FormWindowState.Normal;
                    break;

                case "Chrome":
                case "chrome":
                    Process.Start("chrome","google.com");
                    break;

                case "Note":
                case "note":
                    Process.Start("notepad");
                    break;

                case "manage":
                case "Manage":
                    Process.Start("cmd");
                    break;

                case "close":
                    Close();
                    break;

                #endregion

                #region Swear cases
                case "shit":
                //case "":  
                    break;
                #endregion

                    //case "":
                    //break;



            }
        }



        private void BtnStop_Click(object sender, EventArgs e)
        {
            Close();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }


        
        private void Pause_Click(object sender, EventArgs e)
        {
            if (aaa==0)
            {
                pause.Text = "CONTINUE";
                aaa = 1;
            }
            else if (aaa==1)
            {
                pause.Text = "PAUSE";


                aaa = 0;
            }
        }

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void LOG_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
