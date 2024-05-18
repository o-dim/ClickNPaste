using ClicknPaste.Properties;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClicknPaste
{
    public partial class ClicknPaste : Form
    {
        EmojiGenerator generator = new EmojiGenerator();
        private List<string> wordNames = new List<string>(); // 버튼 이름을 저장할 리스트
        private string selectedWord; // 선택된 단어 저장

        public ClicknPaste()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Size = new Size((int)Size.Width, (int)Size.Height);

            InitializeButtons();

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.FlatAppearance.BorderSize = 0; // 버튼의 경계를 제거
                    btn.FlatStyle = FlatStyle.Flat; // 버튼의 스타일을 flat으로 설정하여 경계를 제거
                    btn.BackColor = Color.FromArgb(0xfc, 0x9f, 0xcc);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                    btn.Font = new Font("sliver", 9);
                }
            }
        }

        private void InitializeButtons()
        {
            Button[] wordButtons = { btn1, btn2, btn3, btn4 };
            string[] words = { "···", "···2", "···3", "···4" };
            for (int i = 0; i < wordButtons.Length; i++)
            {
                wordButtons[i].Text = words[i].ToString();
                wordButtons[i].Click += WordButton_Click;
            }
        }
        private void WordButton_Click(object sender, EventArgs e)
        {
            string randomEmoji = generator.RandEmoji();
            Button button = (Button)sender;
            string word = button.Text;
            // 클립보드에 단어 복사
            Clipboard.SetText(word);
            label1.Text = word + " 이/가 복사됐어! " + randomEmoji;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SaveBtn_click(object sender, EventArgs e)
        {
            var newText = savingText.Text;
            if(newText != null)
            {

            }
            label1.Text = "아직 개발중이야...(◞ ‸ ◟";
        }
        private void editBtn_click(object sender, EventArgs e)
        {
            string randomEmoji = generator.RandEmoji();
            label1.Text = "수정하고 싶은 버튼을 눌러줘 " + randomEmoji;
            foreach (Control control in Controls)
            {
                if(control is Button)
                {
                    Button btn = (Button)control;

                    btn.Click -= WordButton_Click; // 기존 클릭 이벤트 제거
                    btn.Click += WordButton_EditClick; // 새로운 클릭 이벤트 추가

                }

            }
        } 
        private void WordButton_EditClick(object sender, EventArgs e)
        {
            Button button = new Button();
            label1.Text = button.Text.ToString() + "를 " + savingText + "로 바꿀게! 저장버튼을 눌러줘";
        }
        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    string randomEmoji = generator.RandEmoji();
        //    string usingText = "···";
        //    Clipboard.SetText(usingText);
        //    label1.Text = usingText + " 가 복사됐어! " + randomEmoji;
        //}
        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    string randomEmoji = generator.RandEmoji();
        //    string usingText = "궁.";
        //    Clipboard.SetText(usingText);
        //    label1.Text = usingText + " 가 복사됐어! " + randomEmoji;

        //}

        //private void btn3_Click(object sender, EventArgs e)
        //{

        //    string randomEmoji = generator.RandEmoji();
        //    Clipboard.SetText("지나바보");
        //    label1.Text ="지나바보가 복사됐어! " + randomEmoji;
        //}

        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    string randomEmoji = generator.RandEmoji();
        //    Clipboard.SetText("동글푸지나");
        //    
        //}

    }
}
