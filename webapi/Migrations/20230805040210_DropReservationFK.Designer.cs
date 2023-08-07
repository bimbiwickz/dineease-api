﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Models;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(MainDatabaseContext))]
    [Migration("20230805040210_DropReservationFK")]
    partial class DropReservationFK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MealPromotion", b =>
                {
                    b.Property<string>("MealId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("meal_id")
                        .IsFixedLength();

                    b.Property<string>("PromotionId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("promotion_id")
                        .IsFixedLength();

                    b.HasKey("MealId", "PromotionId");

                    b.HasIndex(new[] { "PromotionId" }, "IX_Meal_promotion_promotion_id");

                    b.ToTable("Meal_promotion", (string)null);
                });

            modelBuilder.Entity("webapi.Models.Authentication", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("LastLogged")
                        .HasColumnType("date")
                        .HasColumnName("last_logged");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime")
                        .HasColumnName("last_updated");

                    b.Property<string>("Password")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("password");

                    b.Property<int?>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("salt");

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "Role" }, "IX_Authentication_role");

                    b.ToTable("Authentication");
                });

            modelBuilder.Entity("webapi.Models.Beverage", b =>
                {
                    b.Property<int>("BeverageId")
                        .HasColumnType("int")
                        .HasColumnName("beverage_id");

                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.ToTable("Beverage");
                });

            modelBuilder.Entity("webapi.Models.CalenderDate", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.HasKey("Date");

                    b.HasIndex(new[] { "FoodId" }, "IX_Calender_date_food_id");

                    b.ToTable("Calender_date");
                });

            modelBuilder.Entity("webapi.Models.Checkout", b =>
                {
                    b.Property<string>("OrderId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("orderID")
                        .IsFixedLength();

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("paymentMethod")
                        .IsFixedLength();

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("staffID")
                        .IsFixedLength();

                    b.HasKey("OrderId");

                    b.ToTable("checkout");
                });

            modelBuilder.Entity("webapi.Models.Customer", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<int?>("LoyalityPts")
                        .HasColumnType("int")
                        .HasColumnName("loyality_pts");

                    b.HasKey("UserId")
                        .HasName("PK_Customer_1");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("webapi.Models.Dessert", b =>
                {
                    b.Property<int?>("DessertId")
                        .HasColumnType("int")
                        .HasColumnName("dessert_id");

                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<string>("ServedTemparature")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("served_temparature");

                    b.ToTable("Dessert");
                });

            modelBuilder.Entity("webapi.Models.Favorites", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.HasKey("UserId", "FoodId");

                    b.HasIndex(new[] { "FoodId" }, "IX_Favorites_food_id");

                    b.ToTable("Favorites", "userMGT");
                });

            modelBuilder.Entity("webapi.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("availability");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("categoryID")
                        .IsFixedLength();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("food_name");

                    b.Property<string>("FoodType")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("food_type");

                    b.HasKey("FoodId");

                    b.HasIndex(new[] { "CategoryId" }, "IX_Food_categoryID");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("webapi.Models.FoodCategory", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("categoryID")
                        .IsFixedLength();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("categoryName")
                        .IsFixedLength();

                    b.HasKey("CategoryId")
                        .HasName("PK_foodCategory");

                    b.ToTable("FoodCategory");
                });

            modelBuilder.Entity("webapi.Models.FoodPortions", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<string>("LargePrice")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("large_price")
                        .IsFixedLength();

                    b.Property<string>("RegularPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("regular_price");

                    b.HasKey("FoodId");

                    b.ToTable("Food_portions");
                });

            modelBuilder.Entity("webapi.Models.FoodUser", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FoodId", "UserId");

                    b.ToTable("FoodUser");
                });

            modelBuilder.Entity("webapi.Models.Inventory", b =>
                {
                    b.Property<string>("FoodId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("food_id")
                        .IsFixedLength();

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("webapi.Models.MainDish", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<int>("MainDishId")
                        .HasColumnType("int")
                        .HasColumnName("main_dish_id");

                    b.ToTable("Main_dish");
                });

            modelBuilder.Entity("webapi.Models.Meal", b =>
                {
                    b.Property<string>("MealId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("meal_id")
                        .IsFixedLength();

                    b.Property<string>("Discription")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("discription");

                    b.Property<int>("MealName")
                        .HasColumnType("int")
                        .HasColumnName("meal_name");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.HasKey("MealId");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("webapi.Models.MealFoods", b =>
                {
                    b.Property<string>("MealId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("meal_id")
                        .IsFixedLength();

                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<int>("Quantity1")
                        .HasColumnType("int")
                        .HasColumnName("quantity1");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float")
                        .HasColumnName("unit_price");

                    b.HasKey("MealId")
                        .HasName("PK_Meal_foods_1");

                    b.HasIndex(new[] { "FoodId" }, "IX_Meal_foods_food_id");

                    b.ToTable("Meal_foods");
                });

            modelBuilder.Entity("webapi.Models.Orders", b =>
                {
                    b.Property<string>("OrderId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("order_id")
                        .IsFixedLength();

                    b.Property<double>("Discount")
                        .HasColumnType("float")
                        .HasColumnName("discount");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("order_status")
                        .IsFixedLength();

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("ReservationId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("reservation_id")
                        .IsFixedLength();

                    b.Property<double>("Total")
                        .HasColumnType("float")
                        .HasColumnName("total");

                    b.HasKey("OrderId");

                    b.HasIndex(new[] { "ReservationId" }, "IX_orders_reservation_id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("webapi.Models.Promotion", b =>
                {
                    b.Property<string>("PromotionId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("promotionID")
                        .IsFixedLength();

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("date")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("Discount")
                        .HasColumnType("int")
                        .HasColumnName("discount");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.HasKey("PromotionId");

                    b.ToTable("promotion");
                });

            modelBuilder.Entity("webapi.Models.Reservation", b =>
                {
                    b.Property<string>("ReservationId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("reservation_id")
                        .IsFixedLength();

                    b.Property<byte[]>("ActualDeparture")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("actual_departure");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("Departure")
                        .HasColumnType("datetime")
                        .HasColumnName("departure");

                    b.Property<DateTime?>("ReservationDatetime")
                        .HasColumnType("datetime")
                        .HasColumnName("reservation_datetime");

                    b.Property<Guid>("StaffId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("staff_id");

                    b.Property<int>("TableNo")
                        .HasColumnType("int")
                        .HasColumnName("tableNo");

                    b.HasKey("ReservationId");

                    b.HasIndex(new[] { "TableNo" }, "IX_Reservation_tableNo");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("webapi.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role_name");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("webapi.Models.SideDish", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<int>("SideDishId")
                        .HasColumnType("int")
                        .HasColumnName("side_dish_id");

                    b.ToTable("Side_dish");
                });

            modelBuilder.Entity("webapi.Models.Staff", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<byte?>("IsActive")
                        .HasColumnType("tinyint")
                        .HasColumnName("is_active");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("job_title");

                    b.HasKey("UserId")
                        .HasName("PK_SupportStaff_1");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("webapi.Models.Stater", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("int")
                        .HasColumnName("food_id");

                    b.Property<int>("StaterId")
                        .HasColumnType("int")
                        .HasColumnName("stater_id");

                    b.ToTable("Stater");
                });

            modelBuilder.Entity("webapi.Models.Table", b =>
                {
                    b.Property<int>("TableNo")
                        .HasColumnType("int")
                        .HasColumnName("tableNo");

                    b.Property<string>("Availability")
                        .HasMaxLength(3)
                        .HasColumnType("nchar(3)")
                        .HasColumnName("availability")
                        .IsFixedLength();

                    b.Property<string>("Seating")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("seating")
                        .IsFixedLength();

                    b.HasKey("TableNo");

                    b.ToTable("table");
                });

            modelBuilder.Entity("webapi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("char(12)")
                        .HasColumnName("phone")
                        .IsFixedLength();

                    b.Property<string>("UserImage")
                        .HasColumnType("text")
                        .HasColumnName("user_image");

                    b.Property<string>("UserImageType")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("user_image_type");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .HasColumnName("username")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "IX_User")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("MealPromotion", b =>
                {
                    b.HasOne("webapi.Models.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealId")
                        .IsRequired()
                        .HasConstraintName("FK_Meal_promotion_Meal");

                    b.HasOne("webapi.Models.Promotion", null)
                        .WithMany()
                        .HasForeignKey("PromotionId")
                        .IsRequired()
                        .HasConstraintName("FK_Meal_promotion_promotion");
                });

            modelBuilder.Entity("webapi.Models.Authentication", b =>
                {
                    b.HasOne("webapi.Models.Role", "RoleNavigation")
                        .WithMany("Authentication")
                        .HasForeignKey("Role")
                        .HasConstraintName("FK_Authentication_Role");

                    b.HasOne("webapi.Models.User", "User")
                        .WithOne("Authentication")
                        .HasForeignKey("webapi.Models.Authentication", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Authentication_User");

                    b.Navigation("RoleNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("webapi.Models.CalenderDate", b =>
                {
                    b.HasOne("webapi.Models.Food", "Food")
                        .WithMany("CalenderDate")
                        .HasForeignKey("FoodId")
                        .HasConstraintName("FK_Calender_date_Food");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("webapi.Models.Checkout", b =>
                {
                    b.HasOne("webapi.Models.Orders", "Order")
                        .WithOne("Checkout")
                        .HasForeignKey("webapi.Models.Checkout", "OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_checkout_orders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("webapi.Models.Customer", b =>
                {
                    b.HasOne("webapi.Models.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("webapi.Models.Customer", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Customer_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("webapi.Models.Favorites", b =>
                {
                    b.HasOne("webapi.Models.Food", "Food")
                        .WithMany("Favorites")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Favorites_Food");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("webapi.Models.Food", b =>
                {
                    b.HasOne("webapi.Models.FoodCategory", "Category")
                        .WithMany("Food")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Food_FoodCategory");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("webapi.Models.FoodPortions", b =>
                {
                    b.HasOne("webapi.Models.Food", "Food")
                        .WithOne("FoodPortions")
                        .HasForeignKey("webapi.Models.FoodPortions", "FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_Food_portions_Food");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("webapi.Models.MealFoods", b =>
                {
                    b.HasOne("webapi.Models.Food", "Food")
                        .WithMany("MealFoods")
                        .HasForeignKey("FoodId")
                        .IsRequired()
                        .HasConstraintName("FK_Meal_foods_Food");

                    b.HasOne("webapi.Models.Meal", "Meal")
                        .WithOne("MealFoods")
                        .HasForeignKey("webapi.Models.MealFoods", "MealId")
                        .IsRequired()
                        .HasConstraintName("FK_Meal_foods_Meal");

                    b.Navigation("Food");

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("webapi.Models.Food", b =>
                {
                    b.Navigation("CalenderDate");

                    b.Navigation("Favorites");

                    b.Navigation("FoodPortions");

                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("webapi.Models.FoodCategory", b =>
                {
                    b.Navigation("Food");
                });

            modelBuilder.Entity("webapi.Models.Meal", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("webapi.Models.Orders", b =>
                {
                    b.Navigation("Checkout");
                });

            modelBuilder.Entity("webapi.Models.Role", b =>
                {
                    b.Navigation("Authentication");
                });

            modelBuilder.Entity("webapi.Models.User", b =>
                {
                    b.Navigation("Authentication");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
