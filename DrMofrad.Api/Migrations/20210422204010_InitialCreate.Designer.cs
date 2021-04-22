﻿// <auto-generated />
using System;
using DrMofrad.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrMofrad.Api.Migrations
{
    [DbContext(typeof(DrMofradDbContext))]
    [Migration("20210422204010_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrMofrad.Api.Model.ActivityCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("MoreInfo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId");

                    b.ToTable("ActivityCenters");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Clinic")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsReaded")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleCategoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("ArticleCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrl");

                    b.Property<string>("ImgUrlOne")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrlOne");

                    b.Property<string>("ImgUrlTwo")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrlTwo");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<int?>("LikeCount")
                        .HasColumnType("int");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("ShowCount")
                        .HasColumnType("int");

                    b.Property<string>("SummaryDescription")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(97)
                        .HasColumnType("nvarchar(97)")
                        .HasDefaultValueSql("('')");

                    b.Property<string>("Tag")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleCategoryId");

                    b.HasIndex("LangId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.ArticleCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrl");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ArticleCategories");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId1");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.ContactU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cell")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsReaded")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<int?>("LikeCount")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int?>("ShowCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId2");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<int>("GalleryCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrl");

                    b.Property<string>("ImgUrlOne")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrlOne");

                    b.Property<string>("ImgUrlTwo")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrlTwo");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GalleryCategoryId");

                    b.HasIndex("LangId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.GalleryCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgUrl")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imgUrl");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId3");

                    b.ToTable("GalleryCategories");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.HoursAttend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId4");

                    b.ToTable("HoursAttends");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Lang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.MigrationHistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ContextKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("Model")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("MigrationId", "ContextKey")
                        .HasName("PK_dbo.__MigrationHistory");

                    b.ToTable("__MigrationHistory");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Opinion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Accept")
                        .HasColumnType("bit");

                    b.Property<string>("Answer")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ip")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsReaded")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ArticleId" }, "IX_ArticleId");

                    b.ToTable("Opinions");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasDefaultValueSql("('')");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId5");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.SeoSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("KeywordsPage")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<string>("PageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TitlePage")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId6");

                    b.ToTable("SeoSettings");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.SlideShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("imageUrl");

                    b.Property<int?>("LangId")
                        .HasColumnType("int");

                    b.Property<int>("Orders")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "LangId" }, "IX_LangId")
                        .HasDatabaseName("IX_LangId7");

                    b.ToTable("SlideShows");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramChannel", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("username");

                    b.Property<long?>("Definer")
                        .HasColumnType("bigint")
                        .HasColumnName("definer");

                    b.HasKey("Username")
                        .HasName("PK_dbo.TelegramChannels");

                    b.HasIndex("Definer");

                    b.ToTable("TelegramChannels");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .HasColumnType("int")
                        .HasColumnName("message_id");

                    b.Property<long>("FromId")
                        .HasColumnType("bigint")
                        .HasColumnName("from_id");

                    b.Property<string>("MessageText")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message_text");

                    b.Property<DateTime?>("MessageTime")
                        .HasColumnType("datetime")
                        .HasColumnName("message_time");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("response");

                    b.Property<DateTime?>("ResponseTime")
                        .HasColumnType("datetime")
                        .HasColumnName("response_time");

                    b.Property<bool?>("ShowInPublic")
                        .HasColumnType("bit")
                        .HasColumnName("show_in_public");

                    b.HasKey("MessageId", "FromId")
                        .HasName("PK_dbo.TelegramMessages");

                    b.HasIndex("FromId");

                    b.ToTable("TelegramMessages");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramUser", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LanguageCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("language_code");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("TelegramUsers");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.ActivityCenter", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("ActivityCenters")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.ActivityCenters_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Article", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.ArticleCategory", "ArticleCategory")
                        .WithMany()
                        .HasForeignKey("ArticleCategoryId");

                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("Articles")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.Articles_dbo.Lang_LangId");

                    b.Navigation("ArticleCategory");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Clinic", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("Clinics")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.Clinics_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Faq", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("Faqs")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.Faqs_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Gallery", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.GalleryCategory", "GalleryCategory")
                        .WithMany("Galleries")
                        .HasForeignKey("GalleryCategoryId")
                        .HasConstraintName("FK_dbo.Galleries_dbo.GalleryCategories_GalleryCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("Galleries")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.Galleries_dbo.Lang_LangId");

                    b.Navigation("GalleryCategory");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.GalleryCategory", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("GalleryCategories")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.GalleryCategories_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.HoursAttend", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("HoursAttends")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.HoursAttends_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Opinion", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Article", "Article")
                        .WithMany("Opinions")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK_dbo.Opinions_dbo.Articles_ArticleId");

                    b.Navigation("Article");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Page", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("Pages")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.Pages_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.SeoSetting", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("SeoSettings")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.SeoSettings_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.SlideShow", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.Lang", "Lang")
                        .WithMany("SlideShows")
                        .HasForeignKey("LangId")
                        .HasConstraintName("FK_dbo.SlideShows_dbo.Lang_LangId");

                    b.Navigation("Lang");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramChannel", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.TelegramUser", "DefinerNavigation")
                        .WithMany("TelegramChannels")
                        .HasForeignKey("Definer")
                        .HasConstraintName("FK_TelegramChannels_TelegramUsers");

                    b.Navigation("DefinerNavigation");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramMessage", b =>
                {
                    b.HasOne("DrMofrad.Api.Model.TelegramUser", "From")
                        .WithMany("TelegramMessages")
                        .HasForeignKey("FromId")
                        .HasConstraintName("FK_TelegramMessages_TelegramUsers")
                        .IsRequired();

                    b.Navigation("From");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Article", b =>
                {
                    b.Navigation("Opinions");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.GalleryCategory", b =>
                {
                    b.Navigation("Galleries");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.Lang", b =>
                {
                    b.Navigation("ActivityCenters");

                    b.Navigation("Articles");

                    b.Navigation("Clinics");

                    b.Navigation("Faqs");

                    b.Navigation("Galleries");

                    b.Navigation("GalleryCategories");

                    b.Navigation("HoursAttends");

                    b.Navigation("Pages");

                    b.Navigation("SeoSettings");

                    b.Navigation("SlideShows");
                });

            modelBuilder.Entity("DrMofrad.Api.Model.TelegramUser", b =>
                {
                    b.Navigation("TelegramChannels");

                    b.Navigation("TelegramMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
