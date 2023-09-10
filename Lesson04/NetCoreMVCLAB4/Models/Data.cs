namespace NetCoreMVCLAB4.Models
{
    public class Data
    {
        public static List<People> peoples = new List<People>
            {
                new People (){
                    Id = 1,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },
                new People (){
                    Id = 2,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },
                new People (){
                    Id = 3,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },
                new People (){
                    Id = 4,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },
                new People (){
                    Id = 5,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },
                new People (){
                    Id = 6,
                    Name = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/1.jpg",
                    Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                    Birthday = new DateTime(1986/4/7),
                    Gender =1
                },

            };
        public static List<People> GetPeoples()
        {
            return peoples;
        }
        public static People? GetPeopleById(int id)
        {
            var people = peoples.FirstOrDefault(p => p.Id == id);
            return people;
        }
    }
}
