﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsReviewOOP
{
    public class clsStudent
    {
        // declare the fields
        private string vNumber;
        private string vName;
        private clsDate vBirthdate;
        private Single vGrade;
        // do not declare vAge because it does not store a value


        // ------------ PROPERTIES --------------------
        public string Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }
        public string Name
        {
            get { return vName; }
            set { vName = value; }
        }
        public clsDate BirthDate
        {
            get { return vBirthdate; }
            set { vBirthdate = value; }
        }

        public Single Grade
        {
            get { return vGrade; }
           // set { vName = value; } NO set : Because this property is READ-ONLY
        }

        public int Age
        {
            get { return (DateTime.Today.Year - BirthDate.Year); }
           //set { vName = value; } READ-ONLY
        }

        // -----------CONSTRUCTORS --------------
        public clsStudent()
        {
            vName = "Not defined";
            vBirthdate = new clsDate();
            vGrade = -1;
        }

        public clsStudent(string aNumber, string aName, int aDay, int aMonth, int aYear, Single aGrade)
        {
            Number = aNumber;
            Name = aName ;
            vBirthdate = new clsDate(aDay , aMonth , aYear);
            vGrade = aGrade;
        }

        public clsStudent(string aNumber, string aName, clsDate aDate, Single aGrade)
        {
            Number = aNumber;
            Name = aName;
            BirthDate = aDate;
            vGrade = aGrade;
        }

        //--------------- METHODS --------------
        public void Register(string aName, int aDay, int aMonth, int aYear)
        {
            Name = aName;
            BirthDate = new clsDate(aDay, aMonth, aYear);
            vGrade = -1;
        }
         public bool ToGrade(Single aGrade)
        {
            if( aGrade >= 0 && aGrade <= 100)
            {
                vGrade = aGrade;
                return true;
            } 
            else {   return false;}
        }
        
        public string Display()
        {
            string info = "Number: " + Number + "\nName: " + Name + "\nBirth date : " + BirthDate.ToLetter();
            info += "\nGrade : " + Grade + "/100 \nAge : " + Age + " years \n";
            return info;
        }

    }
}
