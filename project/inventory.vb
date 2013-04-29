Public Class inventory
    Public Enum alcohol1
        beer = 1
        price = 5
    End Enum
    Public Enum drink1
        juice = 1
        price = 2
    End Enum
    Public Enum drink2
        coke = 1
        price = 2
    End Enum
    Public Enum drink3
        milk = 1
        price = 2
    End Enum
    Public Enum drink4
        water = 1
        price = 0
    End Enum
    Public Enum appetizer1  'cheese fries
        fries = 1
        cheese = 1
        price = 5
    End Enum
    Public Enum appetizer2  'potato skins
        potato = 2
        cheese = 1
        price = 4
    End Enum
    Public Enum appetizer3  'salsa
        chips = 1
        salsa = 1
        price = 2
    End Enum
    Public Enum entree1 'honey bbq sandwich
        honey = 1
        bbq = 1
        chickenBreast = 1
        bun = 1
        fries = 1
        chips = 0
        price = 8
    End Enum
    Public Enum entree2 'turkey blt
        turkey = 1
        tomato = 1
        lettuce = 1
        bacon = 1
        bun = 1
        fries = 1
        onion = 1
        chips = 0
        price = 7
    End Enum
    Public Enum entree3 'bacon cheeseburger
        bacon = 1
        cheddarCheese = 1
        burger = 1
        bun = 1
        fries = 1
        chips = 0
        price = 7
    End Enum
    Public Enum dessert1
        iceCream = 1
        price = 3
    End Enum
    Public Enum side1   'fries
        fries = 1
        price = 1
    End Enum
    Public Enum side2   'chips
        chips = 1
        price = 1
    End Enum
    Public Enum side3   'salsa
        salsa = 1
        price = 1
    End Enum
    Public Enum side4   'bacon
        bacon = 1
        price = 1
    End Enum

    Public Const alcohol1s As String = "$5  -  BEER" + vbCrLf
    Public Const drink1s As String = "$2  -  JUICE" + vbCrLf
    Public Const drink2s As String = "$2  -  SODA" + vbCrLf
    Public Const drink3s As String = "$2  -  MILK" + vbCrLf
    Public Const drink4s As String = "$0  -  WATER" + vbCrLf
    Public Const appetizer1s As String = "$5  -  CHEESE FRY" + vbCrLf
    Public Const appetizer2s As String = "$4  -  POTATO SKINS" + vbCrLf
    Public Const appetizer3s As String = "$2  -  CHIPS & SALSA" + vbCrLf
    Public Const entree1s As String = "$8  -  HONEY BBQ" + vbCrLf
    Public Const entree2s As String = "$7  -  TURKEY BLT" + vbCrLf
    Public Const entree3s As String = "$7  -  BACON BURGER" + vbCrLf
    Public Const dessert1s As String = "$3  -  ICE CREAM" + vbCrLf
    Public Const side1s As String = "$1  -  FRIES (side)" + vbCrLf
    Public Const side2s As String = "$1  -  CHIPS (side)" + vbCrLf
    Public Const side3s As String = "$1  -  SALSA (side)" + vbCrLf
    Public Const side4s As String = "$1  -  BACON (side)" + vbCrLf
End Class
