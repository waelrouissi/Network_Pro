using ProfessionalNetwork.Domaine.Entities;
using ProfessionalNetwork.Models;
using ProfessionalNetwork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{
    public class TestController : Controller


    {


        public TestService _ITestervice { get; set; }
        public QuestionService _IQuestionervice { get; set; }

        public TestController()
        {
            
            _ITestervice = new TestService();
            _IQuestionervice = new QuestionService(); 

        }


        // GET: Test
        public ActionResult Index()
        {

            var l = _ITestervice.GetAll();
            List<TestVM> lo = new List<TestVM>();

            foreach (var item in l)
            {
                //var _Test = _ITestervice.GetById(item.TestFK);

               
                lo.Add(
                    new TestVM
                    {
                        Id_Test=item.Id_Test,
                        Name_Test=item.Name_Test,
                        Nbr_Point_Tolal=item.Nbr_Point_Tolal,
                        Nbr_Question=item.Nbr_Question
                        
                    }

                    );

            }

            return View(lo);
        }

        // GET: Test/Details/5
        public ActionResult listquestion(long id)
        {
            var _listquest = _IQuestionervice.GetAll().Where(a => a.TestFK == id).ToList();
            List<QuestionVM> li = new List<QuestionVM>();
            foreach (var q in _listquest)
            {
                li.Add(
                    new QuestionVM
                    {
                        Id_Question = q.Id_Question,
                        Content_Question = q.Content_Question,
                        choice1 = q.choice1,
                        choice2 = q.choice2,
                        choice3 = q.choice3,
                        Correct_AnswerID = q.Correct_AnswerID,
                        Point_Question=q.Point_Question
                       
                       
                        
                    }
                    );
            }
            return View(li);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        public ActionResult Create( TestVM TVM)
        {

            Test t = new Test();
            t.Name_Test = TVM.Name_Test;
            t.Nbr_Question = TVM.Nbr_Question;

            _ITestervice.Add(t);
            _ITestervice.Commit();
            return RedirectToAction("Index");




        }


        public ActionResult CreateQuestion()
        {
            var l = _ITestervice.GetAll();
            List<TestVM> lo = new List<TestVM>();

            foreach (var item in l)
            {
                //var _Test = _ITestervice.GetById(item.TestFK);


                lo.Add(
                    new TestVM
                    {
                        Id_Test = item.Id_Test,
                        Name_Test = item.Name_Test,
                        Nbr_Point_Tolal = item.Nbr_Point_Tolal,
                        Nbr_Question = item.Nbr_Question

                    }

                    );

            }
            ViewBag.TestFK = new SelectList(lo, "Id_Test", "Name_Test");
            return View();
        }
        // POST: Test/CreateQuestion
        [HttpPost]
        public ActionResult CreateQuestion(QuestionVM QVM)
        {

            Question q = new Question();
         

            q.Content_Question = QVM.Content_Question;
            q.choice1 = QVM.choice1;
            q.choice2 = QVM.choice2;
            q.choice3 = QVM.choice3;
            q.Correct_AnswerID = QVM.Correct_AnswerID;
            q.TestFK = QVM.TestFK;
            

            _IQuestionervice.Add(q);
            _IQuestionervice.Commit();


            //
            var l = _ITestervice.GetAll();
            List<TestVM> lo = new List<TestVM>();

            foreach (var item in l)
            {
                //var _Test = _ITestervice.GetById(item.TestFK);


                lo.Add(
                    new TestVM
                    {
                        Id_Test = item.Id_Test,
                        Name_Test = item.Name_Test,
                        Nbr_Point_Tolal = item.Nbr_Point_Tolal,
                        Nbr_Question = item.Nbr_Question

                    }

                    );

            }
            ViewBag.TestFK = new SelectList(lo, "Id_Test", "Name_Test", QVM.TestFK);

            return RedirectToAction("Index");

        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
