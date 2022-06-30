namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle racket = new Rectangle();
        Rectangle[] block = new Rectangle[100];
        bool[] blockVisible = new bool[100];

        Rectangle ball = new Rectangle();

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Orange);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        static int nBlocks = 20;

        static int formW = 300;
        static int formH = 500;

        int racketY = 480;
        int racketW = 50;
        int racketH = 10;

        static int blockY = 60;
        static int blockW = 30;
        static int blockH = 20;
        int cracks;

        // 볼 4분할
        static int ballW = 5;
        static int ballH = 5;

        //볼 좌상(기준점)
        double ballX = formW / 2 - ballW;
        double ballY = blockY + nBlocks / 10 * blockH;




        double slope = -0.1; // 기울기
        double vDir = 1; // 공 수직방향 여부
        
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            // 폼 사이즈
            this.ClientSize = new Size(formW, formH);
            this.Text = "벽돌깨기 v1.0";

            //그래픽 객체 생성
            g = this.CreateGraphics();

            //블록 초기화
            InitBlocks();

            // 라켓 초기화
            InitRacket();

            // 볼 초기화
            InitBall();

        }

        public void InitBlocks()
        {
            for (int i = 0; i < nBlocks; i++)
            {
                block[i] = new Rectangle((i % 10) * blockW,
                                        (i / 10) * blockH + blockY,
                                        blockW - 1,
                                        blockH - 1);
                // 블록 비져블
                blockVisible[i] = true;

                // 깨진 블록 개수
                cracks = 0;
            }
        }

        public void InitRacket()
        {
            racket.X = (formW - racketW) / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        public void InitBall()
        {
            
            ballX = (formW - ballW) / 2;
            ballY = blockY + nBlocks / 10 * blockH;
            ball.X = (formW - ballW) / 2;
            ball.Y = blockY + nBlocks / 10 * blockH;
            ball.Width = ballW;
            ball.Height = ballH;

            // 기울기값 초기화
            slope = rand.Next(5, 20) / 10.0;
            if (rand.Next(2) % 2 == 1)
            {
                slope = -slope;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < nBlocks; i++)
            {
                if (blockVisible[i])
                    g.FillRectangle(blockColor, block[i]);
            }

            //공 그리기
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);



            //라켓 그리기
            g.FillRectangle(racketColor, racket);


        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            Double dx = 0;
            double unit = ballW/5;

            dx = unit / slope;


            ballX += dx;
            ballY += (vDir * slope * dx);

            Console.WriteLine("{0},{1}", ballX, ballY);

            ball.X = (int)ballX;
            ball.Y = (int)ballY;

            // 볼이 좌우 벽에 충돌 했는지 체크
            if (ball.X <= 0 || ball.X >= (formW - ballW))
            {
                slope = -slope;
            }

            // 볼이 라켓에 맞았는지 체크
            if (ball.Y < 0 || racket.IntersectsWith(ball))
            {
                vDir = -vDir;
            }

            // 볼이 벽돌에 맞았는지 체크
            for (int i = 0; i < nBlocks; i++)
            {
                if (ball.IntersectsWith(block[i]) && blockVisible[i])
                {
                    vDir = -vDir;
                    blockVisible[i] = false;
                    cracks++;
                }
                if (cracks == nBlocks)
                {
                    GameOver();
                    //return;
                }
            }

            // 볼을 놓쳤을때
            if (ball.Y > formH)
            {
                GameOver();
                //return;
            }
            
            Invalidate();
        }

        public void GameOver()
        {
            myTimer.Stop();
            DialogResult result;
            if (cracks == nBlocks)
            {
                nBlocks += 10;
                result = MessageBox.Show("다음 단계 ㄱㄱ?", "가메 크레아르", MessageBoxButtons.YesNo);
            }
            else
                result = MessageBox.Show("님 허접! 재시작 ㄱㄱ?", "가메 오베르", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                InitBlocks();
                InitRacket();
                InitBall();

                myTimer.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }

            Invalidate();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Location.X > 0 && e.Location.X < formW - racketW)
                racket.X = e.Location.X;
            Invalidate();
        }
        
    }
}