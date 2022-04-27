/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 26.04.2022
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Zeugnisausgabe
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Name, Datum, Leistungskurs1, Leistungskurs2,Fach3,Fach4, Fach5, Fach6, Fach7, Fach8;
			int  Note1, Note2, Note3, Note4, Note5, Note6, Note7, Note8,Fehltage, Fehltage2;
			double Notenschnitt;
			int a=0;
			int index=0;
			bool Bestätigung=true;
			
			Console.WriteLine("Füllen Sie alle nachfolgenden Felder aus.");
			
			Console.WriteLine(" ");
			Console.WriteLine("----------Zeugnis----------");
			Console.WriteLine(" ");
			
			Console.Write("Name [Mustermann, Max]: ");
			Name=Convert.ToString(Console.ReadLine());
			
			
			
			Console.Write("Datum [TT.MM.JJJJ]: ");
			Datum=Convert.ToString(Console.ReadLine());
			
			
			
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Fehltage: ");
			Fehltage=Convert.ToInt32(Console.ReadLine());
			Console.Write("davon unentschuldigte Fehltage: ");
			Fehltage2 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("-------------------------------------------------------------------");
			Console.Write("Leistungskurs 1: ");
			Leistungskurs1=Convert.ToString(Console.ReadLine());
			
			
			do{
			if (Leistungskurs1.Length>20) {
				Console.WriteLine("ungültiger Fachname aufgrund Sonderzeichen/Länge");
			Console.Write("Leistungskurs 1: ");
			Leistungskurs1=Convert.ToString(Console.ReadLine());
						
			}
				else{Bestätigung=false;}	
			}
			while (Bestätigung);
			Bestätigung = true;
			
			
			Console.Write("Note [0-15]: ");
			Note1 =Convert.ToInt32(Console.ReadLine());
			if ( Note1 > 15 || Note1< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note1<5)
			{
				a=a+1;
			}
			Console.Write("Leistungskurs 2: ");
			Leistungskurs2=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note2 =Convert.ToInt32(Console.ReadLine());
			if ( Note2 > 15|| Note2< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note2<5)
			{
				a=a+1;
			}
			Console.Write("Fach 3: ");
			Fach3=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note3 =Convert.ToInt32(Console.ReadLine());
			if ( Note3 > 15|| Note3< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note3<5)
			{
				a=a+1;
			}
			Console.Write("Fach 4: ");
			Fach4=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note4 =Convert.ToInt32(Console.ReadLine());
			if ( Note4 > 15|| Note4< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note4<5)
			{
				a=a+1;
			}
			Console.Write("Fach 5: ");
			Fach5=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note5 =Convert.ToInt32(Console.ReadLine());
			if ( Note5 > 15|| Note5< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note5<5)
			{
				a=a+1;
			}
			Console.Write("Fach 6: ");
			Fach6=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note6 =Convert.ToInt32(Console.ReadLine());
			if ( Note6 > 15|| Note6< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
				Console.Clear();
			
			}
			if (Note6<5)
			{
				a=a+1;
			}
			Console.Write("Fach 7: ");
			Fach7=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note7 =Convert.ToInt32(Console.ReadLine());
			Console.Write("Fach 8: ");
			if ( Note7 > 15|| Note7< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note7<5)
			{
				a=a+1;
			}
			Fach8=Convert.ToString(Console.ReadLine());
			Console.Write("Note [0-15]: ");
			Note8 =Convert.ToInt32(Console.ReadLine());
			if ( Note8 > 15|| Note8< 0)
			{
				Console.WriteLine("ungültige Eingabe!!! Bitte Programm neustarten");
			
			}
			if (Note8<5)
			{
				a=a+1;
			}
			if(a>2)
			{
				Console.WriteLine("Schüler hat in mehr als zwei Fächern weniger als 5 Punkte und fällt durch!!!");
			}
			if (Fehltage2 > 30)
			{
			Console.WriteLine("Der Schüler wird nicht versetzt.");
			}
			
			
			Console.WriteLine("-------------------------------------------------------------------");
			Notenschnitt = (Note1*2+Note2*2+Note3+Note4+Note5+Note6+Note7+Note8)/10;
			Notenschnitt = (17-Notenschnitt)/3;
			Console.Write("Notendurchschnitt: {0:F1}",Notenschnitt);
			
			
			Console.Clear();
Console.WriteLine(" ");
Console.WriteLine("========= Zeugnis - David-Gymnasium =========");
Console.WriteLine(" ");
Console.WriteLine("Name: " + Name);
Console.WriteLine("Datum: " + Datum);
Console.WriteLine(" ");
Console.WriteLine("=============================================");
Console.WriteLine(" ");
Console.WriteLine("Fehltage: " +Fehltage+" davon unentschuldigt: " +Fehltage2 );
Console.WriteLine(" ");
Console.WriteLine("=============================================");
Console.WriteLine(" ");
Console.WriteLine(Leistungskurs1 + " (LK): " + Note1);
Console.WriteLine(Leistungskurs2 + " (LK): " + Note2);
Console.WriteLine(Fach3 +  ": " + Note3);
Console.WriteLine(Fach4 + ": " + Note4);
Console.WriteLine(Fach5 + ": " + Note5);
Console.WriteLine(Fach6 + ": " + Note6);
Console.WriteLine(Fach7 + ": " + Note7);
Console.WriteLine(Fach8 + ": " + Note8);
Console.WriteLine(" ");
Console.WriteLine("Durschnittsnote: {0:F1}",Notenschnitt);
Console.WriteLine(" ");
Console.WriteLine("=============================================");
Console.WriteLine(" ");
if(a>2 || Fehltage2 > 30)
{
Console.WriteLine(Name + " wird nicht versetzt.");
}
else
{
Console.WriteLine(Name + " wird versetzt.");
}
Console.WriteLine(" ");
Console.WriteLine("=============================================");



string fileName = @"C:\Users\schulung.SCHULUNGNB-03\Desktop\Zeugnis.txt";
StreamWriter writer = new StreamWriter(fileName,true);
writer.WriteLine(" ");
writer.WriteLine("========= Zeugnis - David-Gymnasium =========");
writer.WriteLine(" ");
writer.WriteLine("Name: " + Name);
writer.WriteLine("Datum: " + Datum);
writer.WriteLine(" ");
writer.WriteLine("=============================================");
writer.WriteLine(" ");
writer.WriteLine("Fehltage: " +Fehltage+" davon unentschuldigt: " +Fehltage2 );
writer.WriteLine(" ");
writer.WriteLine("=============================================");
writer.WriteLine(" ");
writer.WriteLine(Leistungskurs1 + " (LK): " + Note1);
writer.WriteLine(Leistungskurs2 + " (LK): " + Note2);
writer.WriteLine(Fach3 + ": " + Note3);
writer.WriteLine(Fach4 + ": " + Note4);
writer.WriteLine(Fach5 + ": " + Note5);
writer.WriteLine(Fach6 + ": " + Note6);
writer.WriteLine(Fach7 + ": " + Note7);
writer.WriteLine(Fach8 + ": " + Note8);
writer.WriteLine(" ");
writer.WriteLine("Durschnittsnote: {0:F1}",Notenschnitt);
writer.WriteLine(" ");
writer.WriteLine("=============================================");
writer.WriteLine(" ");
if(a>2 || Fehltage2 > 30)
{
writer.WriteLine(Name + " wird nicht versetzt.");
}
else
{
writer.WriteLine(Name + " wird versetzt.");
}
writer.WriteLine(" ");
writer.WriteLine("=============================================");

	writer.Close();




			Console.ReadKey(true);
		}
	}
}