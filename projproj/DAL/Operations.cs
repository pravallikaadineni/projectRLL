using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class Operations
    {
        Travelapp1Entities1 context = new Travelapp1Entities1();

        public List<Admin> GetAdmin()
        {
            return context.Admins.ToList();
        }
        public Admin GetAdmin(int id)
        {
            return context.Admins.ToList().Find(x => x.AdminId == id);
        }
        public void PostAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void PutAdmin(int id, Admin admin)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.Admins.Add(admin);
            context.SaveChanges();
        }
        public void DeleteAdmin(int id)
        {
            var found = context.Admins.ToList().Find(x => x.AdminId == id);
            context.Admins.Remove(found);
            context.SaveChanges();
        }






        public List<User> GetUser()
        {
            return context.Users.ToList();
        }
        public User GetUser(int id)
        {
            return context.Users.ToList().Find(x => x.UserId == id);
        }
        public void PostUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void PutUser(int id, User user)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
           found.UserId = user.UserId;
            found.Password=user.Password;
            found.Email=user.Email;
            found.FirstName=user.FirstName;
            found.LastName=user.LastName;
            found.Mobile=user.Mobile;
            found.ConfirmPassword=user.ConfirmPassword;
            found.Photo=user.Photo;
            context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            var found = context.Users.ToList().Find(x => x.UserId == id);
            context.Users.Remove(found);
            context.SaveChanges();
        }
        public List<TravelDetail> GetDetails()
        {
            return context.TravelDetails.ToList();
        }
        public TravelDetail GetDetails(int id)
        {
            return context.TravelDetails.ToList().Find(x => x.TravelId == id);
        }
        public void PostDetails(TravelDetail details)
        {
            context.TravelDetails.Add(details);
            context.SaveChanges();
        }
        public void PutDetails(int id, TravelDetail details)
        {
            var found = context.TravelDetails.ToList().Find(x => x.TravelId == id);
            context.TravelDetails.Remove(found);
            context.TravelDetails.Add(details);
            context.SaveChanges();
        }
        public void DeleteDetails(int id)
        {
            var found = context.TravelDetails.ToList().Find(x => x.TravelId == id);
            context.TravelDetails.Remove(found);
            context.SaveChanges();
        }
        public List<PlacesToVisit> GetPlaces()
        {
            return context.PlacesToVisits.ToList();
        }
        public PlacesToVisit GetPlaces(int id)
        {
            return context.PlacesToVisits.ToList().Find(x => x.PlaceId== id);
        }
        public void PostPlace(PlacesToVisit place)
        {
            context.PlacesToVisits.Add(place);
            context.SaveChanges();
        }
        public void PutPlace(int id, PlacesToVisit place)
        {
            var found = context.PlacesToVisits.ToList().Find(x => x.PlaceId == id);
            context.PlacesToVisits.Remove(found);
            context.PlacesToVisits.Add(place);
            context.SaveChanges();
        }
        public void DeletePlace(int id)
        {
            var found = context.PlacesToVisits.ToList().Find(x => x.PlaceId == id);
            context.PlacesToVisits.Remove(found);
            context.SaveChanges();
        }
       /* public List<Comment> Getcomment()
        {
            return context.Comments.ToList();
        }
        public Comment Getcomment(int id)
        {
            return context.Comments.ToList().Find(x => x.CommentId == id);
        }
        public void Postcomment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
        }
        public void Putcomment(int id, Comment comment)
        {
            var found = context.Comments.ToList().Find(x => x.CommentId == id);
            context.Comments.Remove(found);
            context.Comments.Add(comment);
            context.SaveChanges();
        }
        public void DeleteComment(int id)
        {
            var found = context.Comments.ToList().Find(x => x.CommentId == id);
            context.Comments.Remove(found);
            context.SaveChanges();
        }
        public List<SuggestedHotel> GetHotels()
        {
            return context.SuggestedHotels.ToList();
        }
        public SuggestedHotel GetHotels(int id)
        {
            return context.SuggestedHotels.ToList().Find(x => x.HotelId== id);
        }
        public void PostHotels(SuggestedHotel hotel)
        {
            context.SuggestedHotels.Add(hotel);
            context.SaveChanges();
        }
        public void PutHotels(int id, SuggestedHotel hotel)
        {
            var found = context.SuggestedHotels.ToList().Find(x => x.HotelId == id);
            context.SuggestedHotels.Remove(found);
            context.SuggestedHotels.Add(hotel);
            context.SaveChanges();
        }
        public void DeleteHotels(int id)
        {
            var found = context.SuggestedHotels.ToList().Find(x => x.HotelId == id);
            context.SuggestedHotels.Remove(found);
            context.SaveChanges();
        }*/


    }






}

    
