using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsNDishes.Models{


    public class User
    {
        [Key]
        public int UserId {get;set;}
        
        [Required]
        public string FirstName {get;set;}

        [Required]
        public string LastName {get;set;}

        [Required]
        [AgeValidation]
        public DateTime dateOfBirth {get;set;}
        // Navigation property for related Message objects
        

        public List<Dish> CreatedDishes {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
    }
    public class Dish
    {
        [Key]
        public int DishID {get;set;}
        [Required]
        public string name {get;set;}

        [Required]
        public int Calories {get;set;}
        
        [Required]
        public string description{get;set;}

        [Required]
        public int Tastiness{get;set;}
        
        [Required]
        public int UserId {get;set;}
        // Navigation property for related User object
        
        public User Creator {get;set;}

        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
    public class AgeValidation : ValidationAttribute{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var today = DateTime.Today;
        var age = today.Year - ((DateTime)value).Year;
        var dateOfBirth = (DateTime)value;

        if(dateOfBirth >=  DateTime.Today){
            return new ValidationResult("The date is not correct");
        }


        if(age<18){
            return new ValidationResult("You are underage !!!");
        }
        return ValidationResult.Success;
    }
    }
}

