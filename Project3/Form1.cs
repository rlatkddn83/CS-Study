namespace Project3
{
    public partial class Form1 : Form
    {
        private int margin = 40;
        private int sizeGrid = 30;
        private int sizeDol = 28;
        private int count = 0;

        private int[,] His = new int[27, 27];
        enum Dol { none, mollu, black, white };
        private bool gameOver = false;

        private Graphics g;
        Pen pen = new Pen(Color.Black);
        Brush wBlush, bBlush;
        Rectangle myRect = new Rectangle();
                        
        public Form1()
        {
            InitializeComponent();

            // 그래픽 관련 객체 초기화
            g = this.CreateGraphics();
            pen = new Pen(Color.Black,2);
            wBlush = new SolidBrush(Color.White);
            bBlush = new SolidBrush(Color.Black);

            // 바둑판 색, 크기
            this.Text = "오목 v1.0";
            this.BackColor = Color.Orange;
            this.ClientSize = new Size((2 * margin) + (18 * sizeGrid), (2 * margin) + (18 * sizeGrid));

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameOver)
            {
                int x = ((e.X - margin + (sizeGrid / 2)) / sizeGrid) + 4;
                int y = ((e.Y - margin + (sizeGrid / 2)) / sizeGrid) + 4;

                //Console.WriteLine(x + "," + y);

                myRect.Width = sizeDol;
                myRect.Height = sizeDol;
                myRect.X = margin - (sizeDol / 2) + ((x-4) * sizeGrid);
                myRect.Y = margin - (sizeDol / 2) + ((y-4) * sizeGrid);

                //g.DrawEllipse(pen, myRect);
                if (His[x, y] == 0)
                {
                    if (count % 2 == 0)
                    {
                        g.FillEllipse(bBlush, myRect);
                        His[x, y] = 2;
                    }
                    else
                    {
                        g.FillEllipse(wBlush, myRect);
                        His[x, y] = 3;
                    }
                    Judge(x, y);
                    count++;
                }
            }
            else
            {
                if(MessageBox.Show("재시작 ㅇㅋ?", "재시작", MessageBoxButtons.RetryCancel)==DialogResult.Retry)
                {
                    Invalidate();
                    His = new int[27, 27];
                    count = 0;
                    gameOver = false;
                }
            }
        }

        private void Judge(int x, int y)
        {
            int co3 = 0;
            int[] cc = new int[4];
            int[] cc2 = new int[4];
            List<int> judh = new List<int>();
            List<int> judv = new List<int>();
            List<int> judl = new List<int>();
            List<int> judr = new List<int>();
            int[] vic = new int[4];

            Console.Clear();
            for (int i = -4; i < 5; i++)
            {
                judh.Add(His[x + i, y]);
                judv.Add(His[x, y + i]);
                judl.Add(His[x + i, y + i]);
                judr.Add(His[x - i, y + i]);
            }
            
            for (int i = 0; i < judh.Count; i++)
            {
                if (judh[i] == (count % 2) + 2)
                {
                    vic[0]++;

                }
                else if (judh[i] == 2 || judh[i] == 3)
                {
                    vic[0] = 0;
                }
                else
                {

                }
                if (judv[i] == (count % 2) + 2)
                    vic[1]++;
                else
                    vic[1] = 0;
                if (judl[i] == (count % 2) + 2)
                    vic[2]++;
                else
                    vic[2] = 0;
                if (judr[i] == (count % 2) + 2)
                    vic[3]++;
                else
                    vic[3] = 0;
                if (vic[0] == 5 || vic[1] == 5 || vic[2] == 5 || vic[3] == 5)
                {
                    if (count % 2 == 0)
                    {
                        MessageBox.Show("흑돌의 승!");
                        gameOver = true;
                    }
                    else
                    {
                        MessageBox.Show("백돌의 승!");
                        gameOver = true;
                    }
                }

            }



            if (co3 > 1)
            {
                if (count % 2 == 0)
                {
                    MessageBox.Show("33입니다! 흑돌의 몰수패!");
                    gameOver = true;
                }
                else
                {
                    MessageBox.Show("33입니다! 백돌의 몰수패!");
                    gameOver = true;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //바둑판 눈금 그리기
            // type 1
            for (int i = 0; i < 19; i++)
            {
                g.DrawLine(pen, new Point(margin + sizeGrid * i, margin), new Point(margin + sizeGrid * i, margin + 18 * sizeGrid));
                g.DrawLine(pen, new Point(margin, margin + sizeGrid * i), new Point(margin + 18 * sizeGrid, margin + sizeGrid * i));
            }

            // type 2
            /*
            myRect.Width = sizeGrid;
            myRect.Height = sizeGrid;
            
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    myRect.X = margin + (j * sizeGrid);
                    myRect.Y = margin + (i * sizeGrid);
            
                    g.DrawRectangle(pen, myRect);
                }
            }
            */
        }

    }
}