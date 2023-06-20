using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int [,] m;
        private int f, c;
        public Matriz()
        {
            m = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }public void Cargar(int nf,int nc,int a,int b)
        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;
            for (f1 = 1; f1 <= f; f1++)
                for (c1 = 1; c1 <= c; c1++)
                    m[f1, c1] = r.Next(a, b);
        }
        public string Descargar()
        {
            string s = "";
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    s = s + m[f1, c1] + "\x0009";
                }
                s = s + "\x000d" + "\x000a";
            }                      
            return s;             
        }
        public void Cargar1(int nf,int nc,int vi,int r)
        {
            int f1, c1, i;
            f = nf; c = nc; i = 0;
            for (f1 = f; f1 >= 1; f1--)
                for (c1 = c; c1 >= 1; c1--)
                {
                    i++;
                    m[f1, c1] = vi + (i - 1) * r;
                }
        }
        public void Cargar2(int nf, int nc, int vi, int r)
        {
            int f1, c1, i;
            f = nf; c = nc; i = 0;
            for (c1 = c; c1 >= 1; c1--)
                for (f1 = f; f1 >= 1; f1--)
                {
                    i++;
                    m[f1, c1] = vi + (i - 1) * r;
                }
        }
        public void Sumar (Matriz m2,Matriz m3)
        {
            for (int c1 = c; c1 >= 1; c1--)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    m3.m[f1, c1] = m[f1, c1] + m2.m[f1, c1];
                }
                m3.f = f;
                m3.c = c;
            }
        }
        public void RetornarDimension(ref int nf,ref int nc)
        {
            nf = f;
            nc = c;
        }
        public double Acumulador()
        {
            double Acumulador = 0;
            bool b = true;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    if(b)
                    {
                        Acumulador = Acumulador + Math.Pow(2, m[f1, c1]);
                    }
                    else
                    {
                        Acumulador = Acumulador - Math.Pow(2, m[f1, c1]);
                    }
                }
                b = !b;
            }
            return Acumulador;
        }
        public void Multiplicacion(Matriz m2,Matriz m3)
        {           
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= m2.c; c1++)
                {
                    m3.m[f1, c1] = 0;
                    for (int cf = 1; cf <= c; cf++)
                        m3.m[f1, c1] = m3.m[f1, c1] + m[f1, c1] * m2.m[f1, c1];
                }              
            }
            m3.f = f;
            m3.c = c;
        }
        public bool EncontrarElemento(int ele) //Usando Break
        {
            bool b = false;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = c; c1 >= 1; c1--)
                {
                    if (ele == m[f1, c1])
                    {
                        b = true;
                        break;
                    }                                            
                }
            }
            return b;
        }
        public bool EncontrarElementoW(int ele) //Usando While
        {
            bool b = false;
            int f1 = 1; int c1;
            while((f1<=f)&&(b == false))
            {
                c1 = c;
                while ((c1 >= 1) && (b == false))
                {
                    if (m[f1, c1] == ele)
                        b = true;
                    c1--;
                }
                f1++;      
            }
            return b;
        }
        public void CargarMatrizConEsquema(int nf,int nc,int vi, int r)
        {
            int i = 0;
            f = nf; c = nc;
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = f; f1 >= 1; f1--)
                {
                    i++;
                    m[f1, c1] = vi + (i - 1) * r;
                }
            }            
        }
        //public void BuscarElemento(int nf,int nc ,int ele)
        //{
        //    int c1 = 1; nf = 0; nc = 0;
        //    int f1 = 0;
        //    while ((c1 <= c) && (nf == 0))
        //    {
        //        f1 = f;
        //        while ((f1 >= 1) && (nf == 0))
        //        {
        //            if (m[f1, c1] == ele)
        //            {
        //                nf = f1;
        //                nc = c1;
        //            }
        //            f1--;
        //        }
        //        c1++;
        //    }
        //}
        public int EncontrarElementoMayorDeFila(int nf)
        {
            int may = m[nf,1];
            for (int c1 = 2; c1 <= c; c1++)
            {
                if (m[nf, c1] > may)
                    may = m[nf, c1];
            }
            return may;
        }
        public void MayorDeTodasFilas()
        {
            for (int f1 = 1; f1 <= f; f1++)
            {
                m[f1, c + 1] = EncontrarElementoMayorDeFila(f1);
            }
            c++;
        }
        public  void Intercambiar(int f1,int c1,int f2,int c2)
        {
            int aux;
            aux = m[f1, c1];
            m[f1, c1] = m[f2, c2];
            m[f2, c2] = aux;
        }
        public void OrdenarUnaColumna(int nc)
        {
            for (int t = 1; t <= f-1; t++)
            {
                for (int d = f; d >= t + 1; d--)
                {
                    if (m[d, nc] > m[d - 1, nc])
                        this.Intercambiar(d, nc, d - 1, nc);
                }
            }
        }
        public void OrdenarTodasLasColumnas()
        {
            for (int c1 = 1; c1 <= c; c1++)
            {
                this.OrdenarUnaColumna(c1);
            }
        }



    }
}
