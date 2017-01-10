using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SpeechRecognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENABLE_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            DISABLE.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "hello mark", "what's my name", "i'am fine", "fuck yourself", "go fuck yourself", "who are you","what's your name", "what are you doing", "speak this", "you are idiot" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            //recEngine.SpeechRecognized += recEngine_SpeechRecognized;
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "hello mark":
                    synthesizer.SpeakAsync("Hello sir. How are you?");
                    break;
                case "i'am fine":
                    synthesizer.SpeakAsync("that's good");
                    break;
                case "what's my name":
                    synthesizer.SpeakAsync("DEVA KOUSHAL");
                    break;
                case "what's your name":
                    synthesizer.SpeakAsync(" MY NAME is mark");
                    break;
                case "speak this":
                    synthesizer.SpeakAsync(richTextBox1.SelectedText);
                    break;
                case "who are you":
                    synthesizer.SpeakAsync("Hello!, i am mark");
                    break;
                case "what are you doing":
                    synthesizer.SpeakAsync("I am just compiling ,sir");
                    break;
                case "you are idiot":
                    synthesizer.SpeakAsync("that was rude...");
                    break;
                case "fuck yourself":
                    synthesizer.SpeakAsync("Sorry i can't");
                    break;
                case "go fuck yourself":
                    synthesizer.SpeakAsync("I'am not a human to do that, i'am a program!");
                    break;
            }
        }

        private void DISABLE_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            DISABLE.Enabled = false;
        }
    }
}
