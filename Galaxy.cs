using System;
using System.Collections.Generic;

namespace Galaxy__Windows_
{
    public class Galaxy
    {
        public const double twoPI = 2 * Math.PI;
        public  int numCells0 = 6;                   // the number of cell for first ring.
        public int nRings = 50;                     // the number of rings.
        public int nActive = 20;                   // number of initial active cells.
        public byte activationTime = 15;             // the time of activation of cell.
        public double s;                             // the each cell width.
        public double v = 1;                        // circular velocity.
        public double p = 0.18;                     // star formation probability.
        public double dt = 10;                      // time step.
        //public double t = 0;                        // time.

        public byte[][] cell;
        private int[] active_r, active_a;  // array relative to  radius , angle

        private Random rand = new Random();

        public bool isFinished = false;

        public Galaxy( int nRings, int nActive, byte activationTime, double v, double p, double dt )
        {
            this.nRings = nRings;
            this.nActive = nActive;
            this.activationTime = activationTime;
            this.v = v;
            this.p = p;
            this.dt = dt;
            Initialize();
        }




        private void Initialize()
        {
            int i, x, y, r, a;
            s = twoPI / numCells0;


            cell = new byte[nRings + 1][];
            cell[0] = new byte[1];
            for (i = 0; i <= nRings; i++)
                cell[i] = new byte[i * numCells0];

            active_r = new int[nActive];
            active_a = new int[nActive];
     
            for (i = 0; i < nActive; )
            {
                do
                {
                    x = 1 + rand.Next(nRings);
                    y = 1 + rand.Next(nRings);
                    r = 1 + (int)Math.Sqrt(x * x + y * y);
                } while (r > nRings);

                a = rand.Next(r * numCells0);
                if (cell[r][a] == 0)
                {
                    active_a[i] = a;
                    active_r[i] = r;
                    cell[r][a] = activationTime;
                    i++;
                }
            }

        }
        //-------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------


        public void Evolve(double t)
        {
            List<int> new_active_r = new List<int>();
            List<int> new_active_a = new List<int>();
            int i, ap, am, a, r;
            double wt, angle;

            isFinished = true;
            for (r = 1; r <= nRings; r++)
            {
                int count = r * numCells0;
                for (a = 0; a < count; a++)
                    if (cell[r][a] > 0)
                    {
                        isFinished = false;
                        cell[r][a]--;      // just for decresing shinig star
                    }
            }
            if (isFinished || nActive == 0)
                return;

            for (i = 0; i < nActive; i++)
            {
                r = active_r[i];
                a = active_a[i];

                Create(r, a + 1, new_active_r, new_active_a);
                Create(r, a - 1, new_active_r, new_active_a);
                angle = ((a * s + v * t) / r) % twoPI;
                if (r < nRings)
                {
                    wt = (v * t / (r + 1)) % twoPI;
                    ap = (int)((angle - wt) * (r + 1) / s);
                    ap %= numCells0 * (r + 1);

                    Create(r + 1, ap, new_active_r, new_active_a);
                    Create(r + 1, ap + 1, new_active_r, new_active_a);
                }
                if (r > 1)
                {
                    wt = (v * t / (r - 1)) % twoPI;
                    am = (int)((angle - wt) * (r - 1) / s);
                    am %= numCells0 * (r - 1);

                    Create(r - 1, am, new_active_r, new_active_a);
                    Create(r - 1, am + 1, new_active_r, new_active_a);
                }
            }// end for i

            nActive = new_active_a.Count;
            active_r = new int[nActive];
            active_a = new int[nActive];
            for (i = 0; i < nActive; i++)
            {
                active_r[i] = new_active_r[i];
                active_a[i] = new_active_a[i];
            }

            new_active_a.Clear();
            new_active_r.Clear();

        }



        private void Create(int r, int a, List<int> new_active_r, List<int> new_active_a)
        {
            if (a >= numCells0 * r) a -= numCells0 * r;
            if (a < 0) a += numCells0 * r;
            if (rand.NextDouble() < p && cell[r][a] != activationTime)
            {
                new_active_a.Add(a);
                new_active_r.Add(r);
                cell[r][a] = activationTime;
            }
        }




    }
}
