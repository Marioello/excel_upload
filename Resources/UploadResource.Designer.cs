﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UploadResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UploadResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebApplication.Resources.UploadResource", typeof(UploadResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT {0} FROM [{1}$].
        /// </summary>
        internal static string BaseQuery {
            get {
                return ResourceManager.GetString("BaseQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [id_produk],[nama],[id_kategori],[berat],[harga_beli],[stok],[harga_jual].
        /// </summary>
        internal static string field_barang {
            get {
                return ResourceManager.GetString("field_barang", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [id_trx],[no_invoice],[total_berat],[ongkos_kirim],[total_harga],[total_harga_beli],[kode_user],[alamat_penerima],[tgl_kirim],[id_ekspedisi],[jenis_pengiriman],[tgl_trx].
        /// </summary>
        internal static string field_penjualan {
            get {
                return ResourceManager.GetString("field_penjualan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [id_trx_detail],[id_trx],[no_invoice],[id_produk],[jml_barang],[berat],[harga_satuan],[diskon],[harga].
        /// </summary>
        internal static string field_penjualan_detail {
            get {
                return ResourceManager.GetString("field_penjualan_detail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ticket_code],[ticket_date],[customer_id],[subject],[id_product],[issue].
        /// </summary>
        internal static string field_ticket {
            get {
                return ResourceManager.GetString("field_ticket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [ticket_code],[status],[user_id],[update_date].
        /// </summary>
        internal static string field_ticket_process {
            get {
                return ResourceManager.GetString("field_ticket_process", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to D:\temp\uploads.
        /// </summary>
        internal static string temp_folder {
            get {
                return ResourceManager.GetString("temp_folder", resourceCulture);
            }
        }
    }
}
