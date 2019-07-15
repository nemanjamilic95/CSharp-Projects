using KolokvijumNas.DataSloj;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokvijumNas.BiznisSloj
{
    public class BiznisLogika
    {
        StudijeEntities entiteti = new StudijeEntities();

        public BPredmeti[] dohvatiPredmete()
        {
            IEnumerable<BPredmeti> iePredmeti =
                 from predmet in this.entiteti.Predmets
                 select new BPredmeti
                 {
                     IdPredmet = predmet.idPredmet,
                     PredmetNaziv = predmet.predmetNaziv
                 };
            return iePredmeti.ToArray();

        }
        public BIspitniRok[] dohvatiRokove(int idPredmet)//sa relacijama
        {
            IEnumerable<BIspitniRok> ieRokovi =
                from ispit in this.entiteti.Ispits
                where (idPredmet == 0) ? true : ispit.idPredmet == idPredmet
                select new BIspitniRok
                {

                    IdIspit = ispit.idIspit,
                    PredmetNaziv = ispit.Predmet.predmetNaziv,
                    IspitniRok = ispit.IspitniRok.ispitniRokNaziv,
                    Godina = ispit.IspitniRok.godina
                };
            return ieRokovi.ToArray();
        }
        public BStudentiNaIspitu[] dohvatiStudente(int idIspit)
        {
            IEnumerable<BStudentiNaIspitu> ieStudent =
                from studentIspit in this.entiteti.StudentIspits
                where studentIspit.Ispit.idIspit == idIspit
                select new BStudentiNaIspitu
                {
                    ImePrezime = studentIspit.Student.imePrezime,
                    Index = studentIspit.Student.indeksCalc,
                    Ocena = studentIspit.ocena
                };
            return ieStudent.ToArray();
        }
        public void upisiStudenta(string i,string b,int j,int a) {

            int idStudent = 0;
            ObjectParameter idStudentPar = new ObjectParameter("idStudent", typeof(int));
            this.entiteti.StudentInsert(i,b,j,a, idStudentPar);
            
            if (idStudentPar != null)
            {

                idStudent = (int)idStudentPar.Value;

            }


        }


        public BStudent[] dohvati() {

            IEnumerable<BStudent> ieStudent =
                from student in entiteti.Students
                select new BStudent
                {
                    Ime = student.ime,
                    Prezime = student.prezime,
                    IndeksCalc = student.indeksCalc



                };
            return ieStudent.ToArray();


        }
              

            



        }
    }

