using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Common;

namespace BL
{

    public class DbLib
    {
        public bool CreateCountry(TblCountry p_country)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_country != null)
                    {
                        context.TblCountries.Add(p_country);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static IEnumerable<TblCountry> GetCountryList()
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblCountry> Country = context.TblCountries.ToList();
                    if (Country != null)
                    {
                        return Country;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblYear> GetYearList(int p_Year = 0)
        {
            using (var context = new MyJobPortalEntities())
            {
                IEnumerable<TblYear> f_YearList = null;
                try
                {
                    if (p_Year > 1)
                    {
                        f_YearList = context.TblYears.Where(x => x.Year >= p_Year).ToList();
                    }
                    else
                    {
                        f_YearList = context.TblYears.ToList();
                    }

                    if (f_YearList != null)
                    {
                        return f_YearList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

        }
        public static IEnumerable<TblState> GetStateListByCountryId(int p_CountryId)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblState> f_StateList = context.TblStates.Where(x => x.CountryId == p_CountryId).ToList();
                    if (f_StateList != null)
                    {
                        return f_StateList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblDist> GetDistListByStateId(int p_StateId)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblDist> f_DistList = context.TblDists.Where(x => x.StateId == p_StateId).ToList();
                    if (f_DistList != null)
                    {
                        return f_DistList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblDist> GetDistList()
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblDist> f_DistList = context.TblDists.ToList();
                    if (f_DistList != null)
                    {
                        return f_DistList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblCity> GetCityListByDistId(int p_DistId)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblCity> f_CityList = context.TblCities.Where(x => x.DistId == p_DistId).ToList();
                    if (f_CityList != null)
                    {
                        return f_CityList;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblAnualInLakhSalery> GetAnualSaleryList()
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblAnualInLakhSalery> f_TblAnualInLakhSalery = context.TblAnualInLakhSaleries.ToList();
                    if (f_TblAnualInLakhSalery != null)
                    {
                        return f_TblAnualInLakhSalery;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public static IEnumerable<TblAnualSaleryInThousent> GetAnualSaleryInThousetList()
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    IEnumerable<TblAnualSaleryInThousent> f_TblAnualSaleryInThousent = context.TblAnualSaleryInThousents.ToList();
                    if (f_TblAnualSaleryInThousent != null)
                    {
                        return f_TblAnualSaleryInThousent;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        public bool CreateState(TblState p_State)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_State != null)
                    {
                        context.TblStates.Add(p_State);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool CreateDist(TblDist p_Dist)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_Dist != null)
                    {
                        context.TblDists.Add(p_Dist);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool CreateCity(City p_City)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_City != null)
                    {
                        TblCity f_TblCity = new TblCity();
                        f_TblCity.CityName = p_City.CityName;
                        f_TblCity.DistId = p_City.DistId;
                        f_TblCity.CountryId = p_City.CountryId;
                        context.TblCities.Add(f_TblCity);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool CreateEducation(TblEducation p_Education)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_Education != null)
                    {
                        context.TblEducations.Add(p_Education);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool CreateEmpolyeement(Employement p_Empl)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_Empl != null)
                    {
                        TblSkillSet f_SkillSet = new TblSkillSet();
                        f_SkillSet.SkillSet = p_Empl.SkillSet;
                        context.TblSkillSets.Add(f_SkillSet);
                        context.SaveChanges();

                        TblEmployement f_Employement = new TblEmployement();
                        f_Employement.Designation = p_Empl.Designation;
                        f_Employement.CompanyName = p_Empl.CompanyName;
                        f_Employement.StartYear = p_Empl.StartYear;
                        f_Employement.StartMonth = p_Empl.StartMonth;
                        f_Employement.NoticePeriod = p_Empl.NoticePeriod;
                        f_Employement.SaleryIn = p_Empl.SaleryIn;
                        f_Employement.AnualSaleryInLakh = p_Empl.AnualSaleryInLakh;
                        f_Employement.AnualSaleryInThousent = p_Empl.AnualSaleryInThousent;
                        f_Employement.SkillSetId = f_SkillSet.SkillSetId;
                        f_Employement.LocationDisrictId = p_Empl.LocationDisrictId;
                        f_Employement.IscurrentCompany = true;
                        context.TblEmployements.Add(f_Employement);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public ProfileHeader ProfileHeader(int f_UserId)
        {
            ProfileHeader f_user = new ProfileHeader();
            var context = new MyJobPortalEntities();
            var f_res = from user in context.TblUsers
                        where user.UserId == f_UserId
                        join add in context.TblAddresses on user.UserId equals add.UserId
                        join img in context.TblImages on user.ProfilePicId equals img.ImageId
                        join city in context.TblCities on add.CityId equals city.CityId
                        join emp in context.TblEmployements on user.UserId equals emp.UearId
                        select new
                        {
                            user.FullName,
                            user.MobileNo,
                            add.Address,
                            img.ImagePath,
                            city.CityName,
                            user.EmailId,
                            emp.AnualSaleryInLakh,
                            emp.AnualSaleryInThousent
                        };
            foreach (var res in f_res)
            {
                f_user.Address = res.Address;
                f_user.FullName = res.FullName;
                f_user.CityName = res.CityName;
                f_user.EmailId = res.EmailId;
                f_user.ImagePath = res.ImagePath;
                f_user.AnualSaleryInLakh = res.AnualSaleryInLakh;
                f_user.AnualSaleryInThousent = res.AnualSaleryInThousent;
                f_user.MobileNo = res.MobileNo;
            }

            return f_user;

        }
        public List<TblHighestQualification> GetQualification()
        {
            var context = new MyJobPortalEntities();
            List<TblHighestQualification> f_Qual = context.TblHighestQualifications.ToList();
            return f_Qual;
        }
        public List<TblEducationType> GetEducationType()
        {
            var context = new MyJobPortalEntities();
            List<TblEducationType> f_EducationType = context.TblEducationTypes.ToList();
            return f_EducationType;
        }
        public Education GetEducationDetails(int p_UserId)
        {
            Education f_Education = new Education();
            var context = new MyJobPortalEntities();
            var f_Edgu = from edgu in context.TblEducations
                         where edgu.UserId == p_UserId
                         join hiq in context.TblHighestQualifications on edgu.QualificationId equals hiq.QualificationId
                         select new { edgu.CollageName, edgu.StartMonth, edgu.StartYear, edgu.PassingMonth, edgu.PassingYear, hiq.QualificationName };

            foreach (var Edg in f_Edgu)
            {
                f_Education.QualificationName = Edg.QualificationName;
                f_Education.CollageName = Edg.CollageName;
                f_Education.StartMonth = Edg.StartMonth;
                f_Education.StartYear = Edg.StartYear;
                f_Education.PassingMonth = Edg.PassingMonth;
                f_Education.PassingYear = Edg.PassingYear;
            }

            return f_Education;
        }
        public Employement GetEmployeement(int p_UserId)
        {
            Employement f_Employeement = new Employement();
            var context = new MyJobPortalEntities();
            var f_res = from emp in context.TblEmployements
                        where emp.UearId == p_UserId
                        join skill in context.TblSkillSets on emp.SkillSetId equals skill.SkillSetId

                        select new
                        {
                            emp.CompanyName,
                            emp.Designation,
                            emp.NoticePeriod,
                            emp.StartMonth,
                            emp.StartYear,
                            skill.SkillSet

                        };
            foreach (var res in f_res)
            {
                f_Employeement.CompanyName = res.CompanyName;
                f_Employeement.Designation = res.Designation;
                f_Employeement.NoticePeriod = res.NoticePeriod;
                f_Employeement.StartMonth = res.StartMonth;
                f_Employeement.StartYear = res.StartYear;
                f_Employeement.SkillSet = res.SkillSet;
            }

            return f_Employeement;
        }
        public bool AddSkill(TblSkillSet p_SkillSet)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (p_SkillSet != null)
                    {                       
                        p_SkillSet.UserId = 5;
                        context.TblSkillSets.Add(p_SkillSet);
                        context.SaveChanges();                        
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool AddProject(TblProject f_Project)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (f_Project != null)
                    {
                        f_Project.UserId = 5;
                        context.TblProjects.Add(f_Project);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public bool AddProfileSummery(TblProfileSummery f_ProfileSummery)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    if (f_ProfileSummery != null)
                    {
                        f_ProfileSummery.UserId = 5;
                        context.TblProfileSummeries.Add(f_ProfileSummery);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public int Login(Login p_Login)
        {
            int f_UserId = 0;
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    f_UserId = Convert.ToInt32(context.TblUsers.Where(x => x.EmailId == p_Login.EmailId && x.Password == p_Login.Password).Select(x=>x.UserId).FirstOrDefault());
                    if (f_UserId>0)
                    {
                        return f_UserId;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}