Imports System.Net
Imports System.Net.Mail

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function
    Function LeasingVehicle() As ActionResult
        Return View()
    End Function
    Function BSTKOnline() As ActionResult
        Return View()
    End Function
    Function Portofolio() As ActionResult
        Dim list = New List(Of ListPortofolio)
        Dim row = New ListPortofolio With {.No = 1, .NameProject = "BSTK Online", .Program = "Android Studio (Java)", .View = "BSTKOnline"}
        Dim row2 = New ListPortofolio With {.No = 2, .NameProject = "Leasing Vehicle", .Program = "ASP.Net MVC", .View = "LeasingVehicle"}
        list.Add(row)
        list.Add(row2)
        Return View(list)
    End Function
    Function CreateWebsite() As ActionResult


        Return View()
    End Function
    Function Contact() As ActionResult
        Return View()
    End Function
    <HttpPost()>
    <ValidateAntiForgeryToken()>
    Function Contact(model As SendEmail) As ActionResult
        If ModelState.IsValid Then
            Dim senderEmail = New MailAddress("development200391@gmail.com", "Ramdan")
            Dim receiverEmail = New MailAddress(model.Email)
            Dim password = "D3velopment123"
            Dim body = model.Message
            Dim smtp = New SmtpClient With {
                .Host = "smtp.gmail.com",
                    .Port = 587,
                    .EnableSsl = True,
                    .DeliveryMethod = SmtpDeliveryMethod.Network,
                    .UseDefaultCredentials = False,
                    .Credentials = New NetworkCredential(senderEmail.Address, password)
            }
            Using ms As MailMessage = New MailMessage(senderEmail, receiverEmail) With {.Subject = model.Subject, .Body = body}
                smtp.Send(ms)
            End Using
        End If
        Return View(model)
    End Function

End Class
