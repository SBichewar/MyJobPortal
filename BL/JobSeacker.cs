using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Common;
using System.Data.Entity;
using System.IO;

namespace BL
{
    public class JobSeacker
    {
        public TblUser UserRegister(User f_User)
        {
            using (var context = new MyJobPortalEntities())
            {

                TblUser f_TblUser = new TblUser();
                try
                {
                    TblAddress f_Add = new TblAddress();
                    f_TblUser.EmailId = f_User.EmailId;
                    f_TblUser.EntryDate = DateTime.Now;
                    f_TblUser.UpdateDate = DateTime.Now;
                    f_TblUser.IsEnable = true;
                    f_TblUser.GenderId = f_User.GenderId;
                    f_TblUser.Password = f_User.Password;
                    f_TblUser.FullName = f_User.FullName;
                    context.TblUsers.Add(f_TblUser);
                    context.SaveChanges();
                    f_Add.Address = f_User.Address;
                    f_Add.UserId = f_TblUser.UserId;
                    f_Add.Pincode = f_User.Pincode;
                    f_Add.CityId = f_User.CityId;
                    f_Add.EntryDate = DateTime.Now;
                    f_Add.UpdateDate = DateTime.Now;
                    context.TblAddresses.Add(f_Add);
                    context.SaveChanges();
                    return f_TblUser;
                }
                catch (Exception ex)
                {
                    return f_TblUser;
                }
            }
        }
        public void UserProfiePic(TblUser f_TblUser, String p_ImgFilePath, string p_ResumeName)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    TblImage f_Img = new TblImage();
                    f_Img.ImagePath = p_ImgFilePath;
                    context.TblImages.Add(f_Img);
                    TblResume f_Resume = new TblResume();
                    f_Resume.ResumePath = p_ResumeName;
                    context.TblResumes.Add(f_Resume);
                    context.SaveChanges();
                    f_TblUser.ProfilePicId = f_Img.ImageId;
                    f_TblUser.ResumeId = f_Resume.ResumeId;
                    context.Entry(f_TblUser).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                }

                //contaxt.tb.Add(f_User);
                //contaxt.SaveChanges();
            }
        }
        public void UpdateResume(int p_UserId, string p_ResumePath)
        {
            using (var context = new MyJobPortalEntities())
            {
                try
                {
                    TblUser f_User = context.TblUsers.Where(x => x.UserId == p_UserId).FirstOrDefault();
                    if (f_User != null)
                    {
                        if (f_User.ResumeId != null)
                        {
                            TblResume f_Resume = context.TblResumes.Where(x => x.ResumeId == f_User.ResumeId).FirstOrDefault();
                            if (f_Resume != null)
                            {
                                f_Resume.ResumePath = p_ResumePath;
                                context.SaveChanges();
                            }
                            else
                            {
                                TblResume f_Resm = new TblResume();
                                f_Resm.ResumePath = p_ResumePath;
                                context.TblResumes.Add(f_Resm);
                                f_User.ResumeId = f_Resm.ResumeId;
                                context.SaveChanges();
                            }
                        }
                        else
                        {
                            TblResume f_Resm = new TblResume();
                            f_Resm.ResumePath = p_ResumePath;
                            context.TblResumes.Add(f_Resm);
                            context.SaveChanges();
                            f_User.ResumeId = f_Resm.ResumeId;
                            context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}