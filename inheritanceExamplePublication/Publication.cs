using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceExamplePublication
{
    public enum PublicationType { Misc, Book, Magazine, Article };

    public abstract class Publication
    {
        // fields
        private bool _published = false;
        private DateTime _datePublished;
        private int _totalPages;

        // constructor
        public Publication(string title, string publisher, PublicationType type)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("The title is required.");
            }
            if (string.IsNullOrWhiteSpace(publisher)) { throw new ArgumentException("The publisher is required"); }

            Publisher = publisher;

            Title = title;

            Type = type;
        }

        // properties
        public string Publisher { get; }

        public string Title { get; }

        public PublicationType Type { get; }

        public string? CopyrightName { get; private set; }

        public int CopyrightDate { get; private set; }

        public int Pages
        {
            get { return _totalPages; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "The number of pages cannot be zero or negative.");
                _totalPages = value;
            }
        }


        // methods
        public string GetPublicationDate()
        {
            if (!_published)
                return "NYP";
            else
                return _datePublished.ToString("d");
        }

        public void Publish(DateTime datePublished)
        {
            _published = true;
            _datePublished = datePublished;
        }

        public void Copyright(string copyrightName, int copyrightDate)
        {
            if (string.IsNullOrWhiteSpace(copyrightName))
                throw new ArgumentException("The name of the copyright holder is required.");
            CopyrightName = copyrightName;

            int currentYear = DateTime.Now.Year;
            if (copyrightDate < currentYear - 10 || copyrightDate > currentYear + 2)
                throw new ArgumentOutOfRangeException($"The copyright year must be between {currentYear - 10} and {currentYear + 1}");
            CopyrightDate = copyrightDate;
        }


        // override inherited virtual methods
        public override string ToString() => Title;


    }
}
