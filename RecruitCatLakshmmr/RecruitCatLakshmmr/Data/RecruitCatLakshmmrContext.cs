using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSrinivvv.Models;

namespace RecruitCatLakshmmr.Data
{
    public class RecruitCatLakshmmrContext : DbContext
    {
        public RecruitCatLakshmmrContext (DbContextOptions<RecruitCatLakshmmrContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSrinivvv.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatSrinivvv.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatSrinivvv.Models.Company> Company { get; set; }

        public DbSet<RecruitCatSrinivvv.Models.Industry> Industry { get; set; }
    }
}
