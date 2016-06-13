﻿using Aplikacija.Model;
using Aplikacija.Logika;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    public class Program
    {
        static void Main(string[] args)
        {
            //KorisniciAdmini.dodajAdmina("murta", "pass", "Alen", "Murtic");
            Expression e = new Expression("C(n, m)");
            e.addArguments(new Argument("n", 654.0));
            e.addArguments(new Argument("m", 5));
            //e.addArguments(new Ar)
            Console.WriteLine(e.calculate());
            int i = 0;
            while(i < 1000)
            {
                foreach (var kon in Koncepti.vratiSveKonceptePredmeta(1))
                {
                    foreach (var zadatak in Zadaci.vratiSveZadatkeKoncepta(kon.sifraKoncepta))
                    {
                        KonkretanZadatak zad = new KonkretanZadatak(zadatak.pitanje, zadatak.izraz, zadatak.parametri, null, 1, 3);
                        //Console.WriteLine(zadatak.sifraZadatka + ": " + zad.odgovor);
                        if(zad.odgovor == Double.NaN)
                        {
                            Console.WriteLine(zadatak.sifraZadatka);
                            foreach (var par in zad.parametri)
                            {
                                Console.WriteLine(par);
                            }
                            Console.WriteLine(zad.izraz);   
                        }
                    }
                }
                i++;
                if (i % 50 == 0) Console.WriteLine(i);
            }
            Console.WriteLine("Done");
            //KonkretanZadatak zad = new KonkretanZadatak("fddf", "round(n/k, 0)-round((m-1)/k, 0)", "m:>15&<70 n:>70 k:>5&<12", null, 1, 3);
            //foreach(var par in zad.parametri)
            //{
            //    Console.WriteLine(par);
            //}
            //Console.WriteLine(zad.izraz);
            //Console.WriteLine(zad.odgovor);
            Console.ReadLine();
        }
    }
}
