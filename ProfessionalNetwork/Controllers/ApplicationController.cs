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
    public class ApplicationController : Controller
    {

        public ApplicationService _IApplicationService { get; set; }

        public JobOfferService _IJobOfferService { get; set; }

        public JobSeekerService _IJobSeekerService { get; set; }

        public EntrepriseAdminService _IEntrepriseService { get; set; }

        public InterviewService _IInterviewService { get; set; }

        public ApplicationController()
        {
            _IApplicationService = new ApplicationService();
            _IJobOfferService = new JobOfferService();
            _IJobSeekerService = new JobSeekerService();
            _IEntrepriseService = new EntrepriseAdminService();
            _IInterviewService = new InterviewService();
        }
        // GET: Application
        public ActionResult Index()
        {
            var l = _IApplicationService.GetAll();
            List<ApplicationVM> lo = new List<ApplicationVM>();
            foreach (var item in l)
            {
                var _JobSeeker = _IJobSeekerService.GetById(item.Job_SeekerFK);
                var _JobOffer  = _IJobOfferService.GetById(item.Job_OfferFK);
                lo.Add(
                    new ApplicationVM
                    {
                        Id_Application=item.Id_Application,
                        Job_OfferFK = item.Job_OfferFK,
                        Job_SeekerFK = item.Job_SeekerFK,
                        Date_Application = item.Date_Application,
                        State = item.State,
                        Jobseeker= new JobseekerVM {
                            id_jobseeker= _JobSeeker.id_jobseeker,
                            Intro_jobseeker= _JobSeeker.Intro_jobseeker,
                            Username= _JobSeeker.Username,
                            Last_Name= _JobSeeker.Last_Name,
                            First_Name= _JobSeeker.First_Name,
                            Photo= _JobSeeker.Photo,
                            Date_of_birth= _JobSeeker.Date_of_birth,
                            Date_Created = _JobSeeker.Date_Created,
                            Date_Modified= _JobSeeker.Date_Modified,
                            Date_Deleted= _JobSeeker.Date_Deleted,
                            Certif= _JobSeeker.Certif,
                            Email= _JobSeeker.Email,
                            Enable= _JobSeeker.Enable,
                            Pwd= _JobSeeker.Pwd,
                            IsDeleted= _JobSeeker.IsDeleted,
                            Skills= _JobSeeker.Skills,
                            
                        },
                        Job_Offer=new Job_OfferVM
                        {
                            Id_JobOffer= _JobOffer.Id_JobOffer,
                            Date_Offer= _JobOffer.Date_Offer,
                            Job_Description= _JobOffer.Job_Description,
                            job_title= _JobOffer.job_title,
                            Date_Created= _JobOffer.Date_Created,
                            Date_Deleted= _JobOffer.Date_Deleted,
                            Date_Expiration= _JobOffer.Date_Expiration,
                            Date_Modified= _JobOffer.Date_Modified,
                            Nbr_Candidat= _JobOffer.Nbr_Candidat,
                           // Id_Project_Manager= _JobOffer.Id_Project_Manager,
                            visibility = _JobOffer.visibility,
                            IsDeleted= _JobOffer.IsDeleted,
                            EntrepirseFK= _JobOffer.EntrepirseFK,
                        }
                    }
                 );
            }
            return View(lo);
        }


        // GET: Application/Create
        public ActionResult GetJobOffers()
        {
            var l = _IJobOfferService.GetAll();
            List<Job_OfferVM> lo = new List<Job_OfferVM>();
            foreach (var item in l)
            {
                var _EntrepriseAdmin = _IEntrepriseService.GetById(item.EntrepirseFK);
                lo.Add(
                    new Job_OfferVM
                    {
                        Id_JobOffer=item.Id_JobOffer,
                        job_title=item.job_title,
                        Job_Description=item.Job_Description,
                        Date_Offer=item.Date_Offer,
                        Nbr_Candidat=item.Nbr_Candidat,
                        Date_Expiration=item.Date_Expiration,
                        visibility=item.visibility,
                        EntrepirseFK=item.EntrepirseFK,
                       Entreprise_Admin=new Entreprise_adminVM
                       {
                           Id_Entrepirse= _EntrepriseAdmin.Id_Entrepirse,
                           Email= _EntrepriseAdmin.Email,
                           Name_Entrerise= _EntrepriseAdmin.Name_Entrerise
                       }
                    }
                 );
            }
            return View(lo);
        }
        public ActionResult ShowCondidates(long id)
        {
            var l = _IApplicationService.GetAll().Where(a=>a.Job_OfferFK==id);
            List<ApplicationVM> lo = new List<ApplicationVM>();
            foreach (var item in l)
            {
                var _JobSeeker = _IJobSeekerService.GetById(item.Job_SeekerFK);
                var _JobOffer = _IJobOfferService.GetById(item.Job_OfferFK);
                lo.Add(
                    new ApplicationVM
                    {
                        Id_Application = item.Id_Application,
                        Job_OfferFK = item.Job_OfferFK,
                        Job_SeekerFK = item.Job_SeekerFK,
                        Date_Application = item.Date_Application,
                        State = item.State,
                        Jobseeker = new JobseekerVM
                        {
                            id_jobseeker = _JobSeeker.id_jobseeker,
                            Intro_jobseeker = _JobSeeker.Intro_jobseeker,
                            Username = _JobSeeker.Username,
                            Last_Name = _JobSeeker.Last_Name,
                            First_Name = _JobSeeker.First_Name,
                            Photo = _JobSeeker.Photo,
                            Date_of_birth = _JobSeeker.Date_of_birth,
                            Date_Created = _JobSeeker.Date_Created,
                            Date_Modified = _JobSeeker.Date_Modified,
                            Date_Deleted = _JobSeeker.Date_Deleted,
                            Certif = _JobSeeker.Certif,
                            Email = _JobSeeker.Email,
                            Enable = _JobSeeker.Enable,
                            Pwd = _JobSeeker.Pwd,
                            IsDeleted = _JobSeeker.IsDeleted,
                            Skills = _JobSeeker.Skills,

                        },
                        Job_Offer = new Job_OfferVM
                        {
                            Id_JobOffer = _JobOffer.Id_JobOffer,
                            Date_Offer = _JobOffer.Date_Offer,
                            Job_Description = _JobOffer.Job_Description,
                            job_title = _JobOffer.job_title,
                            Date_Created = _JobOffer.Date_Created,
                            Date_Deleted = _JobOffer.Date_Deleted,
                            Date_Expiration = _JobOffer.Date_Expiration,
                            Date_Modified = _JobOffer.Date_Modified,
                            Nbr_Candidat = _JobOffer.Nbr_Candidat,
                            // Id_Project_Manager= _JobOffer.Id_Project_Manager,
                            visibility = _JobOffer.visibility,
                            IsDeleted = _JobOffer.IsDeleted,
                            EntrepirseFK = _JobOffer.EntrepirseFK,
                        }
                    }
                 );
            }
            return View(lo);
        }
        // GET: Application/Details/5
        public ActionResult Details(long id)
        {
            var item = _IApplicationService.GetById(id);
            var _JobSeeker = _IJobSeekerService.GetById(item.Job_SeekerFK);
            var _JobOffer = _IJobOfferService.GetById(item.Job_OfferFK);
            var _ApplicationVM = new ApplicationVM
            {
                Id_Application = item.Id_Application,
                Job_OfferFK = item.Job_OfferFK,
                Job_SeekerFK = item.Job_SeekerFK,
                Date_Application = item.Date_Application,
                State = item.State,
                Jobseeker = new JobseekerVM
                {
                    id_jobseeker = _JobSeeker.id_jobseeker,
                    Intro_jobseeker = _JobSeeker.Intro_jobseeker,
                    Username = _JobSeeker.Username,
                    Last_Name = _JobSeeker.Last_Name,
                    First_Name = _JobSeeker.First_Name,
                    Photo = _JobSeeker.Photo,
                    Date_of_birth = _JobSeeker.Date_of_birth,
                    Date_Created = _JobSeeker.Date_Created,
                    Date_Modified = _JobSeeker.Date_Modified,
                    Date_Deleted = _JobSeeker.Date_Deleted,
                    Certif = _JobSeeker.Certif,
                    Email = _JobSeeker.Email,
                    Enable = _JobSeeker.Enable,
                    Pwd = _JobSeeker.Pwd,
                    IsDeleted = _JobSeeker.IsDeleted,
                    Skills = _JobSeeker.Skills,
                    FullName= _JobSeeker.Last_Name +" "+ _JobSeeker.First_Name

                },
                Job_Offer = new Job_OfferVM
                {
                    Id_JobOffer = _JobOffer.Id_JobOffer,
                    Date_Offer = _JobOffer.Date_Offer,
                    Job_Description = _JobOffer.Job_Description,
                    job_title = _JobOffer.job_title,
                    Date_Created = _JobOffer.Date_Created,
                    Date_Deleted = _JobOffer.Date_Deleted,
                    Date_Expiration = _JobOffer.Date_Expiration,
                    Date_Modified = _JobOffer.Date_Modified,
                    Nbr_Candidat = _JobOffer.Nbr_Candidat,
                    // Id_Project_Manager= _JobOffer.Id_Project_Manager,
                    visibility = _JobOffer.visibility,
                    IsDeleted = _JobOffer.IsDeleted,
                    EntrepirseFK = _JobOffer.EntrepirseFK,
                }
            };
            return View(_ApplicationVM);
        }

        public long ApplicationId { get; set; }
        // GET: Application/Create
        public ActionResult Accept(long id)
        {
            ApplicationId = id;
            return View();
        }

        // POST: Application/Create
        [HttpPost]
        public ActionResult Accept([Bind(Include = "Id_Interview,Date_Interview, Type_Interview")] InterviewVM vM)
        {

            // TODO: Add insert logic here

            //  var _Date_Interview = Convert.ToString(collection["Date_Interview"]);
            //  var _Type_Interview = Convert.ToString(collection["Type_Interview"]); 
            var _Date_Interview = vM.Date_Interview;
            var _Type_Interview = vM.Type_Interview;
            //if (_Type_Interview=="0")
            //    {
                    _IInterviewService.Add(
                   new Domaine.Entities.Interview
                   {
                       Date_Interview = _Date_Interview,
                       Applciation_FK = 5,
                       TestFK = 1,
                       Type_Interview = Enum_Type_Interview.Technical,
                       State_interview=State_Application.Pending
                   }
                   );
                _IInterviewService.Commit();//error
                return RedirectToAction("GetJobOffers");
           
        }

        public ActionResult Reject(long id)
        {
            var l = _IApplicationService.GetById(id);
            l.State = State_Application.Rejected;
            _IApplicationService.Update(l);
            _IApplicationService.Commit();
            return RedirectToAction("GetJobOffers");
        }
        // GET: Application/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Application/Edit/5
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

        // GET: Application/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Application/Delete/5
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
