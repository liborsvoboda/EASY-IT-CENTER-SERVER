using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EasyITCenter.WebDBModel;

namespace EasyITCenter.WebDBModel {

    public partial class EICWebHostingDbContext : DbContext
    {
        public EICWebHostingDbContext()
        {
        }

        public EICWebHostingDbContext(DbContextOptions<EICWebHostingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionHistoryList> ActionHistoryLists { get; set; } = null!;
        public virtual DbSet<ActionTypeList> ActionTypeLists { get; set; } = null!;
        public virtual DbSet<ApiTableColumnDataList> ApiTableColumnDataLists { get; set; } = null!;
        public virtual DbSet<ApiTableColumnList> ApiTableColumnLists { get; set; } = null!;
        public virtual DbSet<ApiTableList> ApiTableLists { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<DataEntryList> DataEntryLists { get; set; } = null!;
        public virtual DbSet<DataHistoryList> DataHistoryLists { get; set; } = null!;
        public virtual DbSet<DataTypeList> DataTypeLists { get; set; } = null!;
        public virtual DbSet<DeveloperToolList> DeveloperToolLists { get; set; } = null!;
        public virtual DbSet<GeneratedDataList> GeneratedDataLists { get; set; } = null!;
        public virtual DbSet<GeneratorList> GeneratorLists { get; set; } = null!;
        public virtual DbSet<GeneratorTypeList> GeneratorTypeLists { get; set; } = null!;
        public virtual DbSet<HelpDataList> HelpDataLists { get; set; } = null!;
        public virtual DbSet<HelpGroupList> HelpGroupLists { get; set; } = null!;
        public virtual DbSet<ParamTypeList> ParamTypeLists { get; set; } = null!;
        public virtual DbSet<ServerExtensionList> ServerExtensionLists { get; set; } = null!;
        public virtual DbSet<ServerPathList> ServerPathLists { get; set; } = null!;
        public virtual DbSet<ServerPathTypeList> ServerPathTypeLists { get; set; } = null!;
        public virtual DbSet<ServerScriptList> ServerScriptLists { get; set; } = null!;
        public virtual DbSet<SharedPathList> SharedPathLists { get; set; } = null!;
        public virtual DbSet<UserCommentList> UserCommentLists { get; set; } = null!;
        public virtual DbSet<UserMessageList> UserMessageLists { get; set; } = null!;
        public virtual DbSet<UserParamList> UserParamLists { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    if (!optionsBuilder.IsConfigured) {
        //        optionsBuilder.UseSqlServer($"Data Source={SrvConfig.WebHostingDBConnString};AttachDbFilename=E:\\Projekty\\zEasy\\EASY-IT-CENTER\\EASY-IT-CENTER-SERVER\\wwwroot\\server-private\\databases\\EICwebHosting.mdf;Integrated Security=True;Connect Timeout=30",
        //           x => x.UseNetTopologySuite());
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Czech_CP1250_CI_AS");

            modelBuilder.Entity<ActionHistoryList>(entity =>
            {
                entity.ToTable("ActionHistoryList");

                entity.Property(e => e.ActionType).HasMaxLength(100);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.ActionHistoryLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ActionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionHistoryList_ActionTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActionHistoryLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ActionHistoryList_AspNetUsers");
            });

            modelBuilder.Entity<ActionTypeList>(entity =>
            {
                entity.ToTable("ActionTypeList");

                entity.HasIndex(e => e.Name, "IX_ActionTypeList")
                    .IsUnique();

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActionTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionTypeList_ToUser");
            });

            modelBuilder.Entity<ApiTableColumnDataList>(entity =>
            {
                entity.ToTable("ApiTableColumnDataList");

                entity.Property(e => e.ApiTable).HasMaxLength(100);

                entity.Property(e => e.ApiTableColumn).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.ApiTableNavigation)
                    .WithMany(p => p.ApiTableColumnDataLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ApiTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnDataList_ApiTableList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApiTableColumnDataListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnDataList_ToUser");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.ApiTableColumnDataListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.DbPrefix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnDataList_AspNetUsers");
            });

            modelBuilder.Entity<ApiTableColumnList>(entity =>
            {
                entity.ToTable("ApiTableColumnList");

                entity.Property(e => e.ApiTable).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.ApiTableNavigation)
                    .WithMany(p => p.ApiTableColumnLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ApiTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnList_ApiTableList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApiTableColumnListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnList_ToUser");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.ApiTableColumnListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.DbPrefix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableColumnList_AspNetUsers");
            });

            modelBuilder.Entity<ApiTableList>(entity =>
            {
                entity.ToTable("ApiTableList");

                entity.HasIndex(e => e.Name, "IX_ApiTableList")
                    .IsUnique();

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApiTableListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiTableList_ToUser");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.ApiTableListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.DbPrefix)
                    .HasForeignKey(d => d.UserPrefix)
                    .HasConstraintName("FK_ApiTableList_AspNetUsers");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "CStoreIX_AspNetRoles")
                    .IsUnique();

                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.DbPrefix, "IX_AspNetUsers")
                    .IsUnique();

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.DbPrefix).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.RoleId).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<DataEntryList>(entity =>
            {
                entity.ToTable("DataEntryList");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.DataEntryLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .HasConstraintName("FK_DataEntryList_DataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DataEntryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataEntryList_ToUser");
            });

            modelBuilder.Entity<DataHistoryList>(entity =>
            {
                entity.ToTable("DataHistoryList");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(500);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.DataHistoryLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataHistoryList_DataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DataHistoryLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DataHistoryList_AspNetUsers");
            });

            modelBuilder.Entity<DataTypeList>(entity =>
            {
                entity.ToTable("DataTypeList");

                entity.HasIndex(e => e.Name, "IX_DataTypeList")
                    .IsUnique();

                entity.Property(e => e.ActionName).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DataTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DataTypeList_ToUser");
            });

            modelBuilder.Entity<DeveloperToolList>(entity =>
            {
                entity.ToTable("DeveloperToolList");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ToolUrl).HasMaxLength(4000);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.DeveloperToolLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Name)
                    .HasConstraintName("FK_DeveloperToolList_DataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeveloperToolLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeveloperToolList_ToUser");
            });

            modelBuilder.Entity<GeneratedDataList>(entity =>
            {
                entity.ToTable("GeneratedDataList");

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.GeneratorType).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.GeneratedDataLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratedDataList_DataTypeList");

                entity.HasOne(d => d.GeneratorTypeNavigation)
                    .WithMany(p => p.GeneratedDataLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.GeneratorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratedDataList_GeneratedDataList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GeneratedDataListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratedDataList_ToUser");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.GeneratedDataListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.DbPrefix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratedDataList_AspNetUsers");
            });

            modelBuilder.Entity<GeneratorList>(entity =>
            {
                entity.ToTable("GeneratorList");

                entity.HasIndex(e => e.Name, "IX_GeneratorList")
                    .IsUnique();

                entity.Property(e => e.GeneratorType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.GeneratorTypeNavigation)
                    .WithMany(p => p.GeneratorLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.GeneratorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratorList_GeneratorTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GeneratorLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratorList_AspNetUsers");
            });

            modelBuilder.Entity<GeneratorTypeList>(entity =>
            {
                entity.ToTable("GeneratorTypeList");

                entity.HasIndex(e => e.Name, "IX_GeneratorTypeList")
                    .IsUnique();

                entity.Property(e => e.ActionType).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.GeneratorTypeLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ActionType)
                    .HasConstraintName("FK_GeneratorTypeList_ActionTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GeneratorTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneratorTypeList_ToUser");
            });

            modelBuilder.Entity<HelpDataList>(entity =>
            {
                entity.ToTable("HelpDataList");

                entity.Property(e => e.CodeTemplate).HasMaxLength(512);

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.GithubUrl).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HelpDataLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HelpDataList_ToUser");
            });

            modelBuilder.Entity<HelpGroupList>(entity =>
            {
                entity.ToTable("HelpGroupList");

                entity.HasIndex(e => e.Name, "IX_HelpGroupList");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.GithubUrl).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.HelpGroupLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HelpGroupList_DataTypeList");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.HelpGroupLists)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HelpGroupList_AspNetUsers");
            });

            modelBuilder.Entity<ParamTypeList>(entity =>
            {
                entity.ToTable("ParamTypeList");

                entity.HasIndex(e => e.Name, "IX_ParamTypeList");

                entity.Property(e => e.ActionType).HasMaxLength(100);

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.ParamTypeLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamTypeList_ActionTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ParamTypeListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParamTypeList_ToUser");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.ParamTypeListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.DbPrefix)
                    .HasForeignKey(d => d.UserPrefix)
                    .HasConstraintName("FK_ParamTypeList_AspNetUsers");
            });

            modelBuilder.Entity<ServerExtensionList>(entity =>
            {
                entity.ToTable("ServerExtensionList");

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(1024);

                entity.Property(e => e.Url).HasMaxLength(1024);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.ServerExtensionLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerExtensionList_ServerExtensionList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerExtensionLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerExtensionList_ToUser");
            });

            modelBuilder.Entity<ServerPathList>(entity =>
            {
                entity.ToTable("ServerPathList");

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(1024);

                entity.Property(e => e.PathType).HasMaxLength(100);

                entity.Property(e => e.RoleDownload).HasMaxLength(256);

                entity.Property(e => e.RoleReadAccess).HasMaxLength(256);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.ServerPathLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathList_ServerPathList");

                entity.HasOne(d => d.PathTypeNavigation)
                    .WithMany(p => p.ServerPathLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.PathType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathList_ServerPathList1");

                entity.HasOne(d => d.RoleDownloadNavigation)
                    .WithMany(p => p.ServerPathListRoleDownloadNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.RoleDownload)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathList_AspNetRoles");

                entity.HasOne(d => d.RoleReadAccessNavigation)
                    .WithMany(p => p.ServerPathListRoleReadAccessNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.RoleReadAccess)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathList_AspNetRoles1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerPathLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathList_ToUser");
            });

            modelBuilder.Entity<ServerPathTypeList>(entity =>
            {
                entity.ToTable("ServerPathTypeList");

                entity.HasIndex(e => e.Name, "IX_ServerPathTypeList")
                    .IsUnique();

                entity.Property(e => e.Command).HasMaxLength(1024);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerPathTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerPathTypeList_ToUser");
            });

            modelBuilder.Entity<ServerScriptList>(entity =>
            {
                entity.ToTable("ServerScriptList");

                entity.Property(e => e.Command).HasMaxLength(4000);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(1024);

                entity.Property(e => e.RoleDownload).HasMaxLength(256);

                entity.Property(e => e.RoleReadAccess).HasMaxLength(256);

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.ServerScriptLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerScriptList_ServerScriptList");

                entity.HasOne(d => d.RoleDownloadNavigation)
                    .WithMany(p => p.ServerScriptListRoleDownloadNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.RoleDownload)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerScriptList_AspNetRoles");

                entity.HasOne(d => d.RoleReadAccessNavigation)
                    .WithMany(p => p.ServerScriptListRoleReadAccessNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.RoleReadAccess)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerScriptList_AspNetRoles1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerScriptLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerScriptList_ToUser");
            });

            modelBuilder.Entity<SharedPathList>(entity =>
            {
                entity.ToTable("SharedPathList");

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Path).HasMaxLength(1024);

                entity.Property(e => e.SharedUserId).HasMaxLength(450);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.SharedPathLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .HasConstraintName("FK_SharedPathList_DataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SharedPathLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SharedPathList_ToUser");
            });

            modelBuilder.Entity<UserCommentList>(entity =>
            {
                entity.ToTable("UserCommentList");

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCommentLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCommentList_ToUser");
            });

            modelBuilder.Entity<UserMessageList>(entity =>
            {
                entity.ToTable("UserMessageList");

                entity.Property(e => e.MailTo).HasMaxLength(1024);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMessageLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMessageList_ToUser");
            });

            modelBuilder.Entity<UserParamList>(entity =>
            {
                entity.ToTable("UserParamList");

                entity.Property(e => e.CodeTemplate).HasMaxLength(512);

                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ParamType).HasMaxLength(100);

                entity.Property(e => e.User).HasMaxLength(450);

                entity.Property(e => e.UserPrefix).HasMaxLength(50);

                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.UserParamLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserParamList_DataTypeList");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.UserParamLists)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserParamList_ToUsers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
