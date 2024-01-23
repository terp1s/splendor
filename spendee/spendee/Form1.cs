using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spendee
{
    enum barvicky {Green, Red, Blue, Black, White}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CardInitialization()
        {

        }
    }
    class Card
    {
        public Dictionary<barvicky, int> prize { get; set; }
        public barvicky barvicka;
        public int points { get; set; }
        public int rank { get; set; }
        public Card(int r, barvicky gemColour, Dictionary<barvicky,int> priza, int p)
        {
            rank = r;
            barvicka = gemColour;
            prize = priza;
            points = p;
        }
    }
    class Player
    {
        public Dictionary<barvicky, int> slevinka { get; set; }
        public Dictionary<barvicky, int> penizky { get; set; }
        Card[] pujceneKarticky = new Card[3];

        public string name { get; set;}
        public int body { get; set; }
    }
    class Board
    {
        Queue<Card> rank1 = new Queue<Card>();
        Queue<Card> rank2 = new Queue<Card>();
        Queue<Card> rank3 = new Queue<Card>();
        List<Card> aristocrats = new List<Card>();
        Card[] activeAristocrats = new Card[3];
        public Dictionary<barvicky, int> availablePoints { get; set; }

        Board()
        {
            foreach (barvicky i in (barvicky[])Enum.GetValues(typeof(barvicky)))
            {
                availablePoints.Add(i, 5);
            }



        }
        private void ReadFiles()
        {
            string[] stringSeparators = new string[] { @"\tab" };
            var fileStream = new FileStream(@"C:\Users\piskovat\Documents\Karty.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] result = line.Split(stringSeparators, StringSplitOptions.None);
                    Dictionary<barvicky, int> dictionary = new Dictionary<barvicky, int>()
                    {
                        {barvicky.White, result[2] }
                    };
                    Card card = new Card(int.Parse(result[0]), result[1])
                    
            }

        }
    }

    class Game
    {

    }
}


