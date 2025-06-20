using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Security;
using OneDotLearnCore.Training;
using OneDotLearnWebApp.Helpers;
using System.Text;

namespace OneDotLearnWebApp.Pages.Trainees
{
    public class RegistrationModel : PageModel
    {
        #region Data Memebers
        private SecurityHelper secHlpr;
        private OneDotLearnWebHelper odtlWbHlpr;
        #endregion

        #region Constructors
        public RegistrationModel(OneDotLearnWebHelper odtlWebHelpr, SecurityHelper securityHelper)
        {
            odtlWbHlpr = odtlWebHelpr; secHlpr = securityHelper;
        }
        #endregion

        #region Properties
        [BindProperty]
        public string RootUrl { get; set; }
        [BindProperty]
        public string PageUrl { get; set; }
        [BindProperty]
        public string StrIsEssentialDataReady { get; set; }
        [BindProperty]
        public string StrIsEssentialMissing { get; set; }
        [BindProperty]
        public Trainee Trainee { get; set; }
        [BindProperty]
        public string TraineeGender { get; set; }
        [BindProperty]
        public string TraineeBirthDate { get; set; }
        [BindProperty]
        public List<SelectListItem> CountriesList { get; set; }
        [BindProperty]
        public int SelectedCountryId { get; set; }
        [BindProperty]
        public string OtherCountry { get; set; }
        [BindProperty]
        public string OtherNationality { get; set; }
        [BindProperty]
        public int SelectedEduLevel { get; set; }
        [BindProperty]
        public string TraineeEmail { get; set; }
        [BindProperty]
        public string TraineeMobile { get; set; }
        [BindProperty]
        public string TrnCatsChkLst { get; set; }
        [BindProperty]
        public List<int> SelectedTrnCategories { get; set; }
        [BindProperty]
        public string OtherInterests { get; set; }
        [BindProperty]
        public string ProgLangsChkLst { get; set; }
        [BindProperty]
        public List<int> SelectedProgLangs { get; set; }
        [BindProperty]
        public string OtherProgLangs { get; set; }
        [BindProperty]
        public string SWTechsChkLst { get; set; }
        [BindProperty]
        public List<int> SelectedTechnologies { get; set; }
        [BindProperty]
        public string OtherTechnologies { get; set; }
        [BindProperty]
        public List<SelectListItem> ExperienceLevels { get; set; }
        [BindProperty]
        public int SelectedProgExp { get; set; }
        [BindProperty]
        public int SelectedRdbmsExp { get; set; }
        [BindProperty]
        public string LoginName { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string RepeatedPassword { get; set; }
        [BindProperty]
        public string ShowHideWait { get; set; }
        [BindProperty]
        public string SaveResult { get; set; }
        #endregion

        #region Methods
        //public async Task<IActionResult> OnGet()
        public IActionResult OnGet()
        {
            try
            {
                StrIsEssentialDataReady = "block"; StrIsEssentialMissing = "none";

                RootUrl = Request.Host.ToString().RemoveTrailingSlash();
                PageUrl = Request.GetDisplayUrl().RemoveTrailingSlash();

                Trainee = new Trainee()
                {
                    ArFirstName = " ",
                    ArFamilyName = " ",
                    User = new User()
                    {
                        Role = UserRole.Trainee,
                        CreatedById = 1,
                        CreatedOn = $"{DateTime.UtcNow.ToString("dd-mm-yyyy hh:mm:ss.ffff")}",
                        EntityStatus = EntityStatus.Active
                    },
                    CreatedById = 1,
                    CreatedOn = $"{DateTime.UtcNow.ToString("dd-mm-yyyy hh:mm:ss.ffff")}",
                    EntityStatus = EntityStatus.Active
                };

                if (odtlWbHlpr.Countries != null && odtlWbHlpr.Countries.Any())
                {
                    StrIsEssentialDataReady = "block"; StrIsEssentialMissing = "none";
                }
                else
                {
                    StrIsEssentialDataReady = "none"; StrIsEssentialMissing = "block";
                }
                
                CountriesList = odtlWbHlpr.Countries//NoUsa
                        .Select(cn => new SelectListItem(cn.LatinName, $"{cn.Id}")).ToList();
                CountriesList.Add(new SelectListItem("(Other)", "-100"));
                //ExperienceLevels = trnCrsHlp.ExperiencesList.Select(
                //        xp => new SelectListItem(xp.Item1, $"{xp.Item2}")).ToList();

                //var trnCatsSb = new StringBuilder("");
                //foreach (var tc in trnCrsHlp.DetailedCategories)
                //    trnCatsSb.Append("<div class='form-check'>"
                //        + $"<input type='checkbox' name='SelectedTrnCategories' value='{tc.Item1}'/>"
                //        + $"<label>{tc.Item2}</label>"
                //        + "</div>");
                //TrnCatsChkLst = trnCatsSb.ToString();

                //var prgLngSb = new StringBuilder("");
                //foreach (var pl in StringifiedEnums.ProgLangs)
                //    prgLngSb.Append("<div class='form-check'>"
                //            + $"<input type='checkbox' name='SelectedProgLangs' value='{(int)pl.Key}' />"
                //            + $"<label>{pl.Value}</label>"
                //                + "</div>");
                //ProgLangsChkLst = prgLngSb.ToString();

                //var swTechSb = new StringBuilder("");
                //foreach (var swTch in StringifiedEnums.SWDevTechs)
                //    swTechSb.Append("<div class='form-check'>"
                //        + $"<input type='checkbox' name='SelectedTechnologies' value='{(int)swTch.Key}' />"
                //        + $"<label>{swTch.Value}</label>"
                //        + "</div>");
                //SWTechsChkLst = swTechSb.ToString();

                return Page();
            }
            catch (Exception ex)
            {
                //await OneDotSoftWebHelper.Instance.LogErrorAsync(ex);
                return Page();
            }
        }

        public void OnPost()
        {
            secHlpr.AllUsers = new ()
            { 
                new() { Id = 1, FullName= "وليد الغدامسي", LoginName = "waleed" } 
            };
        }
        #endregion
    }
}
