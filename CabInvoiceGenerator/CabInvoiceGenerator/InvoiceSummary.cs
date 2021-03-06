using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //Variables
        private int numberOfRides;
        private double totalFare;
        private double averageFare;
        private string userId;

        /// <summary>
        /// Parametrise constructor for setting data
        /// </summary>
        /// <param name="numberOfRides"></param>
        /// <param name="totalFare"></param>
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            //Setting data
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        public InvoiceSummary(int numberOfRides, double totalFare , double averageFare)
        {
            //Setting data
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        public InvoiceSummary(int numberOfRides, double totalFare, string userId)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.userId = userId;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        /// <summary>
        /// Overriding Equals Method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;
            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputObject.numberOfRides && this.totalFare == inputObject.totalFare && this.averageFare == inputObject.averageFare;
        }

        /// <summary>
        /// Overriding GethHashCode Method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
