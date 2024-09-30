using System;
using System.Collections.Generic;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace EasyITCenter.SharpScript
{

    public class PreviewHtmlEmailResponse {
        public string HtmlEmail { get; set; }
        public string TextEmail { get; set; }
    }


    public class AnagramEqualityComparer : IEqualityComparer<string>, IEqualityComparer<object> {
        public bool Equals(string x, string y) => GetCanonicalString(x) == GetCanonicalString(y);
        public int GetHashCode(string obj) => GetCanonicalString(obj).GetHashCode();
        private string GetCanonicalString(string word) {
            var wordChars = word.ToCharArray();
            Array.Sort(wordChars);
            return new string(wordChars);
        }

        public new bool Equals(object x, object y) => Equals((string)x, (string)y);

        public int GetHashCode(object obj) => GetHashCode((string)obj);
    }


  
    public class Order {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
    }

    public class Product {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public Product() { }
        public Product(int productId, string productName, string category, double unitPrice, int unitsInStock) {
            ProductId = productId;
            ProductName = productName;
            Category = category;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
    }


    public class Customer {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [Reference]
        public List<Order> Orders { get; set; }

        public override string ToString() =>
            $"Customer(customerId='{CustomerId}', companyName='{CompanyName}', orders='{Orders.Count}')";
    }


    public interface ICustomers {
        List<Customer> GetAllCustomers();
        Customer GetCustomer(string customerId);
    }

    public class Customers : ICustomers {
        List<Customer> customers;
        public Customers(List<Customer> customers) => this.customers = customers;

        public List<Customer> GetAllCustomers() => customers;

        public Customer GetCustomer(string customerId) => customers.FirstOrDefault(x => x.CustomerId == customerId);
    }


    public class QueryCustomers : QueryDb<Customer> 
    {
        public string CustomerId { get; set; }
        public string CompanyNameContains { get; set; }
        public string[] CountryIn { get; set; }
    }



    public class QueryGitHubRepos : QueryData<GithubRepo> {
        public string UserName { get; set; }
    }

    public class GithubRepo {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Homepage { get; set; }
        public string Language { get; set; }
        public int Watchers_Count { get; set; }
        public int Stargazes_Count { get; set; }
        public int Forks_Count { get; set; }
        public int Open_Issues_Count { get; set; }
        public int Size { get; set; }
        public string Full_Name { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Pushed_At { get; set; }
        public DateTime? Updated_At { get; set; }

        public bool Has_issues { get; set; }
        public bool Has_Downloads { get; set; }
        public bool Has_Wiki { get; set; }
        public bool Has_Pages { get; set; }
        public bool Fork { get; set; }

        public GithubUser Owner { get; set; }
        public string Svn_Url { get; set; }
        public string Mirror_Url { get; set; }
        public string Url { get; set; }
        public string Ssh_Url { get; set; }
        public string Html_Url { get; set; }
        public string Clone_Url { get; set; }
        public string Git_Url { get; set; }
        public bool Private { get; set; }
    }

    public class GithubUser {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Avatar_Url { get; set; }
        public string Url { get; set; }
        public int? Followers { get; set; }
        public int? Following { get; set; }
        public string Type { get; set; }
        public int? Public_Gists { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string Html_Url { get; set; }
        public int? Public_Repos { get; set; }
        public DateTime? Created_At { get; set; }
        public string Blog { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool? Hireable { get; set; }
        public string Gravatar_Id { get; set; }
        public string Bio { get; set; }
    }

    public class GithubOrg {
        public int Id { get; set; }
        public string Avatar_Url { get; set; }
        public string Url { get; set; }
        public string Login { get; set; }
    }

    public class GithubByUser {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}