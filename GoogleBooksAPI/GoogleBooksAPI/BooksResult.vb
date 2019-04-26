
Public Class BookResults
    Public Property kind As String
    Public Property totalItems As Integer
    Public Property items() As Item()
End Class

Public Class Item
    Public Property kind As String
    Public Property id As String
    Public Property etag As String
    Public Property selfLink As String
    Public Property volumeInfo As Volumeinfo
    Public Property saleInfo As Saleinfo
    Public Property accessInfo As Accessinfo
    Public Property searchInfo As Searchinfo
End Class

Public Class Volumeinfo
    Public Property title As String
    Public Property subtitle As String
    Public Property authors() As String()
    Public Property publishedDate As String
    Public Property industryIdentifiers() As Industryidentifier()
    Public Property readingModes As Readingmodes
    Public Property pageCount As Integer
    Public Property printType As String
    Public Property maturityRating As String
    Public Property allowAnonLogging As Boolean
    Public Property contentVersion As String
    Public Property imageLinks As Imagelinks
    Public Property language As String
    Public Property previewLink As String
    Public Property infoLink As String
    Public Property canonicalVolumeLink As String
    Public Property categories() As String()
    Public Property publisher As String
    Public Property description As String
    Public Property panelizationSummary As Panelizationsummary
End Class

Public Class Readingmodes
    Public Property text As Boolean
    Public Property image As Boolean
End Class

Public Class Imagelinks
    Public Property smallThumbnail As String
    Public Property thumbnail As String
End Class

Public Class Panelizationsummary
    Public Property containsEpubBubbles As Boolean
    Public Property containsImageBubbles As Boolean
End Class

Public Class Industryidentifier
    Public Property type As String
    Public Property identifier As String
End Class

Public Class Saleinfo
    Public Property country As String
    Public Property saleability As String
    Public Property isEbook As Boolean
    Public Property buyLink As String
    Public Property listPrice As Listprice
    Public Property retailPrice As Retailprice
    Public Property offers() As Offer()
End Class

Public Class Listprice
    Public Property amount As Single
    Public Property currencyCode As String
End Class

Public Class Retailprice
    Public Property amount As Single
    Public Property currencyCode As String
End Class

Public Class Offer
    Public Property finskyOfferType As Integer
    Public Property listPrice As Listprice1
    Public Property retailPrice As Retailprice1
    Public Property giftable As Boolean
End Class

Public Class Listprice1
    Public Property amountInMicros As Single
    Public Property currencyCode As String
End Class

Public Class Retailprice1
    Public Property amountInMicros As Single
    Public Property currencyCode As String
End Class

Public Class Accessinfo
    Public Property country As String
    Public Property viewability As String
    Public Property embeddable As Boolean
    Public Property publicDomain As Boolean
    Public Property textToSpeechPermission As String
    Public Property epub As Epub
    Public Property pdf As Pdf
    Public Property webReaderLink As String
    Public Property accessViewStatus As String
    Public Property quoteSharingAllowed As Boolean
End Class

Public Class Epub
    Public Property isAvailable As Boolean
    Public Property downloadLink As String
    Public Property acsTokenLink As String
End Class

Public Class Pdf
    Public Property isAvailable As Boolean
    Public Property downloadLink As String
    Public Property acsTokenLink As String
End Class

Public Class Searchinfo
    Public Property textSnippet As String
End Class
