//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.CartItems = new HashSet<CartItem>();
            this.Colors = new HashSet<Color>();
            this.Comments = new HashSet<Comment>();
            this.Images = new HashSet<Image>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Ships = new HashSet<Ship>();
        }
    
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> UnitPriceNew { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public Nullable<bool> Published { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string ShortDecription { get; set; }
        public Nullable<int> TotalDeal { get; set; }
        public Nullable<int> MaxDeal { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string URL { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> LabelProductId { get; set; }
        public string Codition { get; set; }
        public string HighLight { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public Nullable<bool> IsVoucher { get; set; }
        public Nullable<bool> IsSlider { get; set; }
        public Nullable<int> origin_id { get; set; }
        public Nullable<int> TypeCategories { get; set; }
        public Nullable<int> ProductDisCountID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Color> Colors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
        public virtual LabelProduct LabelProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ProductDisCount ProductDisCount { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ship> Ships { get; set; }
        public virtual tbl_origin tbl_origin { get; set; }
        public virtual tbl_TypeCategories tbl_TypeCategories { get; set; }
    }
}