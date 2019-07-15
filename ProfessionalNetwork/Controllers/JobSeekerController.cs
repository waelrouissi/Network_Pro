using ProfessionalNetwork.Domaine.Entities;
using ProfessionalNetwork.Models;
using ProfessionalNetwork.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ProfessionalNetwork.Controllers
{
    public class JobSeekerController : Controller

    {

        public ApplicationService _IApplicationService { get; set; }

        public JobOfferService _IJobOfferService { get; set; }

        public JobSeekerService _IJobSeekerService { get; set; }

        public EntrepriseAdminService _IEntrepriseService { get; set; }

        public InterviewService _IInterviewService { get; set; }

        public JobSeekerController()
        {
            _IApplicationService = new ApplicationService();
            _IJobOfferService = new JobOfferService();
            _IJobSeekerService = new JobSeekerService();
            _IEntrepriseService = new EntrepriseAdminService();
            _IInterviewService = new InterviewService();
        }

        // GET: JobSeeker
        public ActionResult Index()
        {
            List<JobseekerVM> list = new List<JobseekerVM>();

            foreach (var item in _IJobSeekerService.GetAll())
            {
                JobseekerVM JS = new JobseekerVM();

                JS.First_Name = item.First_Name;
                JS.Last_Name = item.Last_Name;
                JS.Date_of_birth = item.Date_of_birth;
                JS.Photo = item.Photo;
                JS.Intro_jobseeker = item.Intro_jobseeker;
                JS.Certif = item.Certif;
                JS.Skills = item.Skills;
                JS.Email = item.Email;
                JS.Username = item.Username;
                JS.Pwd = item.Pwd;
                JS.id_jobseeker = item.id_jobseeker;

                list.Add(JS);
            }

            return View(list);

        }

        // GET: JobSeeker/Details/5
        public ActionResult Details(int id)
        {
            var item = _IJobSeekerService.GetById(id);
            var JS = new JobseekerVM
            {

                First_Name = item.First_Name,
                Last_Name = item.Last_Name,
                Date_of_birth = item.Date_of_birth,
                Photo = item.Photo,
                Intro_jobseeker = item.Intro_jobseeker,
                Certif = item.Certif,
                Skills = item.Skills,
                Email = item.Email,
                id_jobseeker = item.id_jobseeker

            };

            return View(JS);



        }

        // GET: JobSeeker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobSeeker/Create
        [HttpPost]
        public ActionResult Create(JobseekerVM JSVM)
        {
            Jobseeker JS = new Jobseeker();


            JS.First_Name = JSVM.First_Name;
            JS.Last_Name = JSVM.Last_Name;
            JS.Date_of_birth = JSVM.Date_of_birth;
            JS.Photo = JSVM.Photo;
            JS.Intro_jobseeker = JSVM.Intro_jobseeker;
            JS.Certif = JSVM.Certif;
            JS.Skills = JSVM.Skills;
            JS.Email = JSVM.Email;
            JS.Username = JSVM.Username;
            JS.Pwd = JSVM.Pwd;

            _IJobSeekerService.Add(JS);
            _IJobSeekerService.Commit();

            var fromAddress = new MailAddress("test.projetbi2019@gmail.com");
            var fromPassword = "27952514.";
            //var toAddress = new MailAddress(JS.Email);
            var toAddress = new MailAddress("test.projetbi2019@gmail.com");

            string subject = "Subscprtion Succeded !! ";
            string body = "Hello"+JS.First_Name+" "+JS.Last_Name+"welcome in our Social Network";

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })


                smtp.Send(message);

            return RedirectToAction("Index");

        }

        // GET: JobSeeker/Edit/5
        public ActionResult Edit(int id)
        {

            Jobseeker item = _IJobSeekerService.GetById(id);
            JobseekerVM JSVM = new JobseekerVM();

            JSVM.First_Name = item.First_Name;
            JSVM.Last_Name = item.Last_Name;
            JSVM.Date_of_birth = item.Date_of_birth;
            JSVM.Photo = item.Photo;
            JSVM.Intro_jobseeker = item.Intro_jobseeker;
            JSVM.Certif = item.Certif;
            JSVM.Skills = item.Skills;
            JSVM.Email = item.Email;
            JSVM.Username = item.Username;
            JSVM.Pwd = item.Pwd;
            JSVM.id_jobseeker = id;


            return View(JSVM);

        }

        // POST: JobSeeker/Edit/5
        [HttpPost]
        public ActionResult Edit(JobseekerVM JSVM)
        {
            try
            {
                Jobseeker item = _IJobSeekerService.GetById(JSVM.id_jobseeker);
                item.First_Name = JSVM.First_Name;
                item.Last_Name = JSVM.Last_Name;
                item.Date_of_birth = JSVM.Date_of_birth;
                item.Photo = JSVM.Photo;
                item.Intro_jobseeker = JSVM.Intro_jobseeker;
                item.Certif = JSVM.Certif;
                item.Skills = JSVM.Skills;
                item.Email = JSVM.Email;
                item.Username = JSVM.Username;
                item.Pwd = JSVM.Pwd;

                _IJobSeekerService.Update(item);
                _IJobSeekerService.Commit();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        //// GET: JobSeeker/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // GET: JobSeeker/Delete/5
        public ActionResult Delete(int id)
        {

            // TODO: Add delete logic here

            _IJobSeekerService.Delete(_IJobSeekerService.GetById(id));
            _IJobSeekerService.Commit();

            return RedirectToAction("Index");
        }
    }
}

