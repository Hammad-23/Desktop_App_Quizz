using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz_App
{
    public partial class CompSci : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int totalQuestions;
        public CompSci()
        {

            InitializeComponent();
            askQuestions(questionNumber);
            totalQuestions = 8;
            
        }

        private void CompSci_Load(object sender, EventArgs e)
        {

        }

        private void askQuestions(int qNum)
        {
            switch (qNum)
            {
                case 1:
                    lblQ.Text = "Which of the following languages is more suited to a structured program?";
                    btnOpt1.Text = "PL/1";
                    btnOpt2.Text = "FORTRAN";
                    btnOpt3.Text = "BASIC";
                    btnOpt4.Text = "PASCAL";
                    correctAnswer = 4;

                    break;

                case 2:
                    lblQ.Text = "The brain of any computer system is";
                    btnOpt1.Text = "ALU";
                    btnOpt2.Text = "Memory";
                    btnOpt3.Text = "CPU";
                    btnOpt4.Text = "Control unit";
                    correctAnswer = 3;

                    break;

                case 3:
                    lblQ.Text = "Which of the following computer language is used for artificial intelligence?";
                    btnOpt1.Text = "FORTRAN";
                    btnOpt2.Text = "PROLOG";
                    btnOpt3.Text = "C";
                    btnOpt4.Text = "COBOL";
                    correctAnswer = 2;

                    break;

                case 4:
                    lblQ.Text = "Which of the following is the 1's complement of 10?";
                    btnOpt1.Text = "01";
                    btnOpt2.Text = "110";
                    btnOpt3.Text = "11";
                    btnOpt4.Text = "10";
                    correctAnswer = 1;

                    break;

                case 5:
                    lblQ.Text = "Which part interprets program instructions and initiate control operations.";
                    btnOpt1.Text = "Input";
                    btnOpt2.Text = "Storage unit";
                    btnOpt3.Text = "Logic unit";
                    btnOpt4.Text = "Control unit";
                    correctAnswer = 4;

                    break;
                    
                case 6:
                    lblQ.Text = "The binary system uses powers of";
                    btnOpt1.Text = "2";
                    btnOpt2.Text = "10";
                    btnOpt3.Text = "8";
                    btnOpt4.Text = "16";
                    correctAnswer = 1;

                    break;

                case 7:
                    lblQ.Text = "A computer program that converts assembly language to machine language is";
                    btnOpt1.Text = "Compiler";
                    btnOpt2.Text = "Interpreter";
                    btnOpt3.Text = "Assembler";
                    btnOpt4.Text = "Comparator";
                    correctAnswer = 3;

                    break;

                case 8:
                    lblQ.Text = "The time for which a piece of equipment operates is called";
                    btnOpt1.Text = "Seek time";
                    btnOpt2.Text = "Effective time";
                    btnOpt3.Text = "Access time";
                    btnOpt4.Text = "Real time";
                    correctAnswer = 2;

                    break;

                case 9:
                    lblQ.Text = "A name applied by Intel corp. to high speed MOS technology is called";
                    btnOpt1.Text = "HDLC";
                    btnOpt2.Text = "LAP";
                    btnOpt3.Text = "HMOS";
                    btnOpt4.Text = "SDLC";
                    correctAnswer = 3;

                    break;

                case 10:
                    lblQ.Text = "A common boundary between two systems is called";
                    btnOpt1.Text = "Interdiction";
                    btnOpt2.Text = "Interface";
                    btnOpt3.Text = "Surface";
                    btnOpt4.Text = "None of the above";
                    correctAnswer = 2;

                    break;

            }


        }

        private void btnOpt1_Click(object sender, EventArgs e)
        {
            questionNumber++;
            askQuestions(questionNumber);
        }
    }
}
