using Cassandra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBP_Cassandra.Data;

namespace NBP_Cassandra
{
    class DataProvider
    {
        #region Member
        public static void AddMember(string id, string fn, string ln)
        {
            ISession session = CassandraManager.GetSession();

            if (session == null)
                return;

            RowSet MemberData = session.Execute("insert into member(memberid, firstname, lastname) values ('" + id + "', '" + fn + "', '" + ln + "')"); 
        }

        public static Member GetMember(string id)
        {
            ISession session = CassandraManager.GetSession();
            Member member = new Member();

            if (session == null)
                return null;

            Row memberData = session.Execute("Select * from member where memberid = '" + id + "'").FirstOrDefault();

            if (memberData != null)
            {
                member.MemberID = memberData["memberid"] != null ? memberData["memberid"].ToString() : string.Empty;
                member.FirstName = memberData["firstname"] != null ? memberData["firstname"].ToString() : string.Empty;
                member.LastName = memberData["lastname"] != null ? memberData["lastname"].ToString() : string.Empty;
            }

            return member;
        }

        public static void DeleteMember(string id)
        {
            ISession session = CassandraManager.GetSession();
            Member member = new Member();

            if (session == null)
                return;

            RowSet memberData = session.Execute("delete from member where memberid = '" + id + "'");

        }

        public static List<Member> AllMembers()
        {
            ISession session = CassandraManager.GetSession();
            List<Member> members = new List<Member>();

            if (session == null)
                return null;

            var membersData = session.Execute("select * from member");

            foreach (var memberData in membersData)
            {
                Member member= new Member();
                member.MemberID = memberData["memberid"] != null ? memberData["memberid"].ToString() : string.Empty;
                member.FirstName = memberData["firstname"] != null ? memberData["firstname"].ToString() : string.Empty;
                member.LastName = memberData["lastname"] != null ? memberData["lastname"].ToString() : string.Empty;
                members.Add(member);
            }

            return members;
        }
        #endregion

        #region Membership
        public static bool AddMembership(string id, string lf, string lu, string g)
        {
            ISession session = CassandraManager.GetSession();

            if (session == null)
                return false;

            RowSet MembershipData;
            Row memberData = session.Execute("Select * from member where memberid = '" + id + "'").FirstOrDefault();
            if (memberData != null)
            {
                MembershipData = session.Execute("insert into membership(memberid, lastsfrom, lastsuntil, gym) values ('" + id + "', '" + lf + "', '" + lu + "', '" + g + "')");
                return true;
            }
            else
                return false;
        }

        public static Membership GetMembership(string id)
        {
            ISession session = CassandraManager.GetSession();
            Membership membership = new Membership();

            if (session == null)
                return null;

            Row membershipData = session.Execute("Select * from membership where memberid = '" + id + "'").FirstOrDefault();

            if (membershipData != null)
            {
                membership.MemberID = membershipData["memberid"] != null ? membershipData["memberid"].ToString() : string.Empty;
                membership.LastsFrom = membershipData["lastsfrom"] != null ? membershipData["lastsfrom"].ToString() : string.Empty;
                membership.LastsUntil= membershipData["lastsuntil"] != null ? membershipData["lastsuntil"].ToString() : string.Empty;
                membership.Gym = membershipData["gym"] != null ? membershipData["gym"].ToString() : string.Empty;
            }

            return membership;
        }

        public static void DeleteMembership(string id)
        {
            ISession session = CassandraManager.GetSession();
            Membership membership = new Membership();

            if (session == null)
                return;

            RowSet membershipData = session.Execute("delete from membership where memberid = '" + id + "'");

        }

        public static List<Membership> AllMemberships()
        {
            ISession session = CassandraManager.GetSession();
            List<Membership> memberships = new List<Membership>();

            if (session == null)
                return null;

            var membershipsData = session.Execute("select * from membership");

            foreach (var membershipData in membershipsData)
            {
                Membership membership = new Membership();
                membership.MemberID = membershipData["memberid"] != null ? membershipData["memberid"].ToString() : string.Empty;
                membership.LastsFrom = membershipData["lastsfrom"] != null ? membershipData["lastsfrom"].ToString() : string.Empty;
                membership.LastsUntil = membershipData["lastsuntil"] != null ? membershipData["lastsuntil"].ToString() : string.Empty;
                membership.Gym = membershipData["gym"] != null ? membershipData["gym"].ToString() : string.Empty;
                memberships.Add(membership);
            }

            return memberships;
        }
        #endregion

        #region Gym
        public static void AddGym(string name, string phone, string address, string city, string country)
        {
            ISession session = CassandraManager.GetSession();

            if (session == null)
                return;

            RowSet GymData = session.Execute("insert into gym(name, phone, address, city, country) values ('" + name + "', '" + phone + "', '" + address + "', '" + city + "', '" + country + "')");
        }

        public static Gym GetGym(string name)
        {
            ISession session = CassandraManager.GetSession();
            Gym gym = new Gym();

            if (session == null)
                return null;

            Row gymData = session.Execute("Select * from gym where name = '" + name + "'").FirstOrDefault();

            if (gymData != null)
            {
                gym.Name = gymData["name"] != null ? gymData["name"].ToString() : string.Empty;
                gym.Phone = gymData["phone"] != null ? gymData["phone"].ToString() : string.Empty;
                gym.Address = gymData["address"] != null ? gymData["address"].ToString() : string.Empty;
                gym.City = gymData["city"] != null ? gymData["city"].ToString() : string.Empty;
                gym.Country = gymData["country"] != null ? gymData["country"].ToString() : string.Empty;
            }

            return gym;
        }

        public static void DeleteGym(string name)
        {
            ISession session = CassandraManager.GetSession();
            Gym gym = new Gym();

            if (session == null)
                return;

            RowSet gymData = session.Execute("delete from gym where name = '" + name + "'");

        }

        public static List<Gym> AllGyms()
        {
            ISession session = CassandraManager.GetSession();
            List<Gym> gyms = new List<Gym>();

            if (session == null)
                return null;

            var gymsData = session.Execute("select * from gym");

            foreach (var gymData in gymsData)
            {
                Gym gym = new Gym();
                gym.Name = gymData["name"] != null ? gymData["name"].ToString() : string.Empty;
                gym.Phone = gymData["phone"] != null ? gymData["phone"].ToString() : string.Empty;
                gym.Address = gymData["address"] != null ? gymData["address"].ToString() : string.Empty;
                gym.City = gymData["city"] != null ? gymData["city"].ToString() : string.Empty;
                gym.Country = gymData["country"] != null ? gymData["country"].ToString() : string.Empty;
                gyms.Add(gym);
            }

            return gyms;
        }
        #endregion

        #region Workout
        public static bool AddWorkout(string workoutid, string memberid, string gymname, string date, string starttime, string endtime, string exercise)
        {
            ISession session = CassandraManager.GetSession();

            if (session == null)
                return false;

            RowSet WorkoutData;
            Row memberData = session.Execute("Select * from member where memberid = '" + memberid + "'").FirstOrDefault();
            if (memberData != null)
            {
                WorkoutData = session.Execute("insert into workout(workoutid, memberid, gymname, date, starttime, endtime, exercise) values ('" + workoutid + "', '" + memberid + "', '" + gymname + "', '" + date + "', '" + starttime + "', '" + endtime + "', '" + exercise + "')");
                return true;
            }
            else
                return false;
        }

        public static Workout GetWorkout(string workoutid)
        {
            ISession session = CassandraManager.GetSession();
            Workout workout = new Workout();

            if (session == null)
                return null;

            Row workoutData = session.Execute("Select * from workout where workoutid = '" + workoutid + "'").FirstOrDefault();

            if (workoutData != null)
            {
                workout.WorkoutID = workoutData["workoutid"] != null ? workoutData["workoutid"].ToString() : string.Empty;
                workout.MemberID = workoutData["memberid"] != null ? workoutData["memberid"].ToString() : string.Empty;
                workout.GymName = workoutData["gymname"] != null ? workoutData["gymname"].ToString() : string.Empty;
                workout.Date = workoutData["date"] != null ? workoutData["date"].ToString() : string.Empty;
                workout.StartTime = workoutData["starttime"] != null ? workoutData["starttime"].ToString() : string.Empty;
                workout.EndTime = workoutData["endtime"] != null ? workoutData["endtime"].ToString() : string.Empty;
                workout.Exercise = workoutData["exercise"] != null ? workoutData["exercise"].ToString() : string.Empty;
            }

            return workout;
        }

        public static List<Workout> GetWorkoutByMemberID(string memberid)
        {
            ISession session = CassandraManager.GetSession();
            List<Workout> workouts = new List<Workout>();

            if (session == null)
                return null;

            var workoutsData = session.Execute("select * from workout where memberid = '" + memberid + "' allow filtering");

            foreach (var workoutData in workoutsData)
            {
                Workout workout = new Workout();
                workout.WorkoutID = workoutData["workoutid"] != null ? workoutData["workoutid"].ToString() : string.Empty;
                workout.MemberID = workoutData["memberid"] != null ? workoutData["memberid"].ToString() : string.Empty;
                workout.GymName = workoutData["gymname"] != null ? workoutData["gymname"].ToString() : string.Empty;
                workout.Date = workoutData["date"] != null ? workoutData["date"].ToString() : string.Empty;
                workout.StartTime = workoutData["starttime"] != null ? workoutData["starttime"].ToString() : string.Empty;
                workout.EndTime = workoutData["endtime"] != null ? workoutData["endtime"].ToString() : string.Empty;
                workout.Exercise = workoutData["exercise"] != null ? workoutData["exercise"].ToString() : string.Empty;
                workouts.Add(workout);
            }

            return workouts;
        }

        public static List<Workout> GetWorkoutByDate(string date)
        {
            ISession session = CassandraManager.GetSession();
            List<Workout> workouts = new List<Workout>();

            if (session == null)
                return null;

            var workoutsData = session.Execute("select * from workout where date = '" + date + "' allow filtering");

            foreach (var workoutData in workoutsData)
            {
                Workout workout = new Workout();
                workout.WorkoutID = workoutData["workoutid"] != null ? workoutData["workoutid"].ToString() : string.Empty;
                workout.MemberID = workoutData["memberid"] != null ? workoutData["memberid"].ToString() : string.Empty;
                workout.GymName = workoutData["gymname"] != null ? workoutData["gymname"].ToString() : string.Empty;
                workout.Date = workoutData["date"] != null ? workoutData["date"].ToString() : string.Empty;
                workout.StartTime = workoutData["starttime"] != null ? workoutData["starttime"].ToString() : string.Empty;
                workout.EndTime = workoutData["endtime"] != null ? workoutData["endtime"].ToString() : string.Empty;
                workout.Exercise = workoutData["exercise"] != null ? workoutData["exercise"].ToString() : string.Empty;
                workouts.Add(workout);
            }

            return workouts;
        }

        public static void DeleteWorkout(string workoutid)
        {
            ISession session = CassandraManager.GetSession();
            Workout workout = new Workout();

            if (session == null)
                return;

            RowSet workoutData = session.Execute("delete from workout where workoutid = '" + workoutid + "'");

        }

        public static List<Workout> AllWorkouts()
        {
            ISession session = CassandraManager.GetSession();
            List<Workout> workouts = new List<Workout>();

            if (session == null)
                return null;

            var workoutsData = session.Execute("select * from workout");

            foreach (var workoutData in workoutsData)
            {
                Workout workout = new Workout();
                workout.WorkoutID = workoutData["workoutid"] != null ? workoutData["workoutid"].ToString() : string.Empty;
                workout.MemberID = workoutData["memberid"] != null ? workoutData["memberid"].ToString() : string.Empty;
                workout.GymName = workoutData["gymname"] != null ? workoutData["gymname"].ToString() : string.Empty;
                workout.Date = workoutData["date"] != null ? workoutData["date"].ToString() : string.Empty;
                workout.StartTime = workoutData["starttime"] != null ? workoutData["starttime"].ToString() : string.Empty;
                workout.EndTime = workoutData["endtime"] != null ? workoutData["endtime"].ToString() : string.Empty;
                workout.Exercise = workoutData["exercise"] != null ? workoutData["exercise"].ToString() : string.Empty;
                workouts.Add(workout);
            }

            return workouts;
        }
        #endregion
    }
}
