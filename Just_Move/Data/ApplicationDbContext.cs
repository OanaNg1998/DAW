using IdentityServer4.EntityFramework.Options;
using Just_Move.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Gym> Gym { get; set; }
        public DbSet<GymInstructors> GymInstructors { get; set; }
        public DbSet<GymTrainings> GymTrainings { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorTrainings> InstructorTrainings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }


    }
}
