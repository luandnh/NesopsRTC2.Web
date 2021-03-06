using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Mapping
{
    public partial class CcCardMap
        : IEntityTypeConfiguration<NesopsService.Data.Entities.CcCard>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<NesopsService.Data.Entities.CcCard> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_card");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("bigint(20)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Creationdate)
                .IsRequired()
                .HasColumnName("creationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(t => t.Firstusedate)
                .IsRequired()
                .HasColumnName("firstusedate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Expirationdate)
                .IsRequired()
                .HasColumnName("expirationdate")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Enableexpire)
                .HasColumnName("enableexpire")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Expiredays)
                .HasColumnName("expiredays")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Username)
                .IsRequired()
                .HasColumnName("username")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Useralias)
                .IsRequired()
                .HasColumnName("useralias")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Uipass)
                .IsRequired()
                .HasColumnName("uipass")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Credit)
                .IsRequired()
                .HasColumnName("credit")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Tariff)
                .HasColumnName("tariff")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.IdDidgroup)
                .HasColumnName("id_didgroup")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Activated)
                .IsRequired()
                .HasColumnName("activated")
                .HasColumnType("char(1)")
                .HasMaxLength(1)
                .HasDefaultValueSql("'f'");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("status")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Lastname)
                .IsRequired()
                .HasColumnName("lastname")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Firstname)
                .IsRequired()
                .HasColumnName("firstname")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Address)
                .IsRequired()
                .HasColumnName("address")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.City)
                .IsRequired()
                .HasColumnName("city")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.State)
                .IsRequired()
                .HasColumnName("state")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Country)
                .IsRequired()
                .HasColumnName("country")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Zipcode)
                .IsRequired()
                .HasColumnName("zipcode")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Phone)
                .IsRequired()
                .HasColumnName("phone")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Fax)
                .IsRequired()
                .HasColumnName("fax")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Inuse)
                .HasColumnName("inuse")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Simultaccess)
                .HasColumnName("simultaccess")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Currency)
                .HasColumnName("currency")
                .HasColumnType("char(3)")
                .HasMaxLength(3)
                .HasDefaultValueSql("'USD'");

            builder.Property(t => t.Lastuse)
                .IsRequired()
                .HasColumnName("lastuse")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Nbused)
                .HasColumnName("nbused")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Typepaid)
                .HasColumnName("typepaid")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Creditlimit)
                .HasColumnName("creditlimit")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Voipcall)
                .HasColumnName("voipcall")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.SipBuddy)
                .HasColumnName("sip_buddy")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.IaxBuddy)
                .HasColumnName("iax_buddy")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Language)
                .HasColumnName("language")
                .HasColumnType("char(5)")
                .HasMaxLength(5)
                .HasDefaultValueSql("'en'");

            builder.Property(t => t.Redial)
                .IsRequired()
                .HasColumnName("redial")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Runservice)
                .HasColumnName("runservice")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Nbservice)
                .HasColumnName("nbservice")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.IdCampaign)
                .HasColumnName("id_campaign")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.NumTrialsDone)
                .HasColumnName("num_trials_done")
                .HasColumnType("bigint(20)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Vat)
                .IsRequired()
                .HasColumnName("vat")
                .HasColumnType("float");

            builder.Property(t => t.Servicelastrun)
                .IsRequired()
                .HasColumnName("servicelastrun")
                .HasColumnType("timestamp(6)")
                .HasDefaultValueSql("'0000-00-00 00:00:00'");

            builder.Property(t => t.Initialbalance)
                .IsRequired()
                .HasColumnName("initialbalance")
                .HasColumnType("decimal(15,5)");

            builder.Property(t => t.Invoiceday)
                .HasColumnName("invoiceday")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.Autorefill)
                .HasColumnName("autorefill")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Loginkey)
                .IsRequired()
                .HasColumnName("loginkey")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.MacAddr)
                .IsRequired()
                .HasColumnName("mac_addr")
                .HasColumnType("char(17)")
                .HasMaxLength(17)
                .HasDefaultValueSql("'00-00-00-00-00-00'");

            builder.Property(t => t.IdTimezone)
                .HasColumnName("id_timezone")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'0'");

            builder.Property(t => t.Tag)
                .IsRequired()
                .HasColumnName("tag")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.VoicemailPermitted)
                .IsRequired()
                .HasColumnName("voicemail_permitted")
                .HasColumnType("int(11)");

            builder.Property(t => t.VoicemailActivated)
                .IsRequired()
                .HasColumnName("voicemail_activated")
                .HasColumnType("smallint(6)");

            builder.Property(t => t.LastNotification)
                .HasColumnName("last_notification")
                .HasColumnType("timestamp(6)");

            builder.Property(t => t.EmailNotification)
                .IsRequired()
                .HasColumnName("email_notification")
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.NotifyEmail)
                .IsRequired()
                .HasColumnName("notify_email")
                .HasColumnType("smallint(6)");

            builder.Property(t => t.CreditNotification)
                .IsRequired()
                .HasColumnName("credit_notification")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'-1'");

            builder.Property(t => t.IdGroup)
                .IsRequired()
                .HasColumnName("id_group")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'1'");

            builder.Property(t => t.CompanyName)
                .IsRequired()
                .HasColumnName("company_name")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CompanyWebsite)
                .IsRequired()
                .HasColumnName("company_website")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60);

            builder.Property(t => t.VatRn)
                .HasColumnName("vat_rn")
                .HasColumnType("varchar(40)")
                .HasMaxLength(40);

            builder.Property(t => t.Traffic)
                .HasColumnName("traffic")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.TrafficTarget)
                .IsRequired()
                .HasColumnName("traffic_target")
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);

            builder.Property(t => t.Discount)
                .IsRequired()
                .HasColumnName("discount")
                .HasColumnType("decimal(5,2)");

            builder.Property(t => t.Restriction)
                .IsRequired()
                .HasColumnName("restriction")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.IdSeria)
                .HasColumnName("id_seria")
                .HasColumnType("int(11)");

            builder.Property(t => t.Serial)
                .HasColumnName("serial")
                .HasColumnType("bigint(20)");

            builder.Property(t => t.Block)
                .IsRequired()
                .HasColumnName("block")
                .HasColumnType("tinyint(4)");

            builder.Property(t => t.LockPin)
                .HasColumnName("lock_pin")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.LockDate)
                .HasColumnName("lock_date")
                .HasColumnType("timestamp(6)");

            builder.Property(t => t.MaxConcurrent)
                .IsRequired()
                .HasColumnName("max_concurrent")
                .HasColumnType("int(11)")
                .HasDefaultValueSql("'10'");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_card";

        public const string ColumnId = "id";
        public const string ColumnCreationdate = "creationdate";
        public const string ColumnFirstusedate = "firstusedate";
        public const string ColumnExpirationdate = "expirationdate";
        public const string ColumnEnableexpire = "enableexpire";
        public const string ColumnExpiredays = "expiredays";
        public const string ColumnUsername = "username";
        public const string ColumnUseralias = "useralias";
        public const string ColumnUipass = "uipass";
        public const string ColumnCredit = "credit";
        public const string ColumnTariff = "tariff";
        public const string ColumnIdDidgroup = "id_didgroup";
        public const string ColumnActivated = "activated";
        public const string ColumnStatus = "status";
        public const string ColumnLastname = "lastname";
        public const string ColumnFirstname = "firstname";
        public const string ColumnAddress = "address";
        public const string ColumnCity = "city";
        public const string ColumnState = "state";
        public const string ColumnCountry = "country";
        public const string ColumnZipcode = "zipcode";
        public const string ColumnPhone = "phone";
        public const string ColumnEmail = "email";
        public const string ColumnFax = "fax";
        public const string ColumnInuse = "inuse";
        public const string ColumnSimultaccess = "simultaccess";
        public const string ColumnCurrency = "currency";
        public const string ColumnLastuse = "lastuse";
        public const string ColumnNbused = "nbused";
        public const string ColumnTypepaid = "typepaid";
        public const string ColumnCreditlimit = "creditlimit";
        public const string ColumnVoipcall = "voipcall";
        public const string ColumnSipBuddy = "sip_buddy";
        public const string ColumnIaxBuddy = "iax_buddy";
        public const string ColumnLanguage = "language";
        public const string ColumnRedial = "redial";
        public const string ColumnRunservice = "runservice";
        public const string ColumnNbservice = "nbservice";
        public const string ColumnIdCampaign = "id_campaign";
        public const string ColumnNumTrialsDone = "num_trials_done";
        public const string ColumnVat = "vat";
        public const string ColumnServicelastrun = "servicelastrun";
        public const string ColumnInitialbalance = "initialbalance";
        public const string ColumnInvoiceday = "invoiceday";
        public const string ColumnAutorefill = "autorefill";
        public const string ColumnLoginkey = "loginkey";
        public const string ColumnMacAddr = "mac_addr";
        public const string ColumnIdTimezone = "id_timezone";
        public const string ColumnTag = "tag";
        public const string ColumnVoicemailPermitted = "voicemail_permitted";
        public const string ColumnVoicemailActivated = "voicemail_activated";
        public const string ColumnLastNotification = "last_notification";
        public const string ColumnEmailNotification = "email_notification";
        public const string ColumnNotifyEmail = "notify_email";
        public const string ColumnCreditNotification = "credit_notification";
        public const string ColumnIdGroup = "id_group";
        public const string ColumnCompanyName = "company_name";
        public const string ColumnCompanyWebsite = "company_website";
        public const string ColumnVatRn = "vat_rn";
        public const string ColumnTraffic = "traffic";
        public const string ColumnTrafficTarget = "traffic_target";
        public const string ColumnDiscount = "discount";
        public const string ColumnRestriction = "restriction";
        public const string ColumnIdSeria = "id_seria";
        public const string ColumnSerial = "serial";
        public const string ColumnBlock = "block";
        public const string ColumnLockPin = "lock_pin";
        public const string ColumnLockDate = "lock_date";
        public const string ColumnMaxConcurrent = "max_concurrent";
        #endregion
    }
}
