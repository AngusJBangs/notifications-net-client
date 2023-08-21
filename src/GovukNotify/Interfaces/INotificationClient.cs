using Notify.Models;
using Notify.Models.Responses;
using System.Collections.Generic;
using System.Threading;

namespace Notify.Interfaces
{
    public interface INotificationClient : IBaseClient
    {
        TemplatePreviewResponse GenerateTemplatePreview(string templateId, Dictionary<string, dynamic> personalisation = null, CancellationToken cancellationToken = default);

        TemplateList GetAllTemplates(string templateType = "", CancellationToken cancellationToken = default);

        Notification GetNotificationById(string notificationId, CancellationToken cancellationToken = default);

        NotificationList GetNotifications(string templateType = "", string status = "", string reference = "", string olderThanId = "", bool includeSpreadsheetUploads = false, CancellationToken cancellationToken = default);

        ReceivedTextListResponse GetReceivedTexts(string olderThanId = "", CancellationToken cancellationToken = default);

        TemplateResponse GetTemplateById(string templateId, CancellationToken cancellationToken = default);

        TemplateResponse GetTemplateByIdAndVersion(string templateId, int version = 0, CancellationToken cancellationToken = default);

        SmsNotificationResponse SendSms(string mobileNumber, string templateId, Dictionary<string, dynamic> personalisation = null, string clientReference = null, string smsSenderId = null, CancellationToken cancellationToken = default);

        EmailNotificationResponse SendEmail(string emailAddress, string templateId, Dictionary<string, dynamic> personalisation = null, string clientReference = null, string emailReplyToId = null, CancellationToken cancellationToken = default);

        LetterNotificationResponse SendLetter(string templateId, Dictionary<string, dynamic> personalisation, string clientReference = null, CancellationToken cancellationToken = default);

        LetterNotificationResponse SendPrecompiledLetter(string clientReference, byte[] pdfContents, string postage = null, CancellationToken cancellationToken = default);
    }
}
