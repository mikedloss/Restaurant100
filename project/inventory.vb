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
    Public Enum appetizer2  'sampler
        potato = 2
        cheddarCheese = 1
        price = 8
    End Enum
    Public Enum appetizer3  'potato skins
        potato = 2
        cheese = 1
        price = 4
    End Enum
    Public Enum appetizer4  'salsa
        chips = 1
        salsa = 1
        price = 2
    End Enum
    Public Enum appetizer5  'mozzerlla sticks
        breading = 4
        mozCheese = 4
        price = 4
    End Enum
    Public Enum appetizer6  'bone-in wings
        wingBone = 6
        price = 5
    End Enum
    Public Enum appetizer7  'bone-less wings
        wingBoneless = 6
        price = 5
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
    End Enum

    Public Const alcohol1s As String = "$5  -  1 BEER" + vbCrLf
    Public Const drink1s As String = "$2  -  1 JUICE" + vbCrLf
    Public Const drink2s As String = "$2  -  1 SODA" + vbCrLf
    Public Const drink3s As String = "$2  -  1 MILK" + vbCrLf
    Public Const drink4s As String = "$0  -  1 WATER" + vbCrLf
    Public Const appetizer1s As String = "$5  -  1 CHEESE FRY" + vbCrLf
    Public Const appetizer2s As String = "$8  -  1 APP SAMPLER" + vbCrLf
    Public Const appetizer3s As String = "$4  -  1 POTATO SKINS" + vbCrLf
    Public Const appetizer4s As String = "$2  -  1 CHIPS & SALSA" + vbCrLf
    Public Const appetizer5s As String = "$4  -  1 MOZ STICKS" + vbCrLf
    Public Const appetizer6s As String = "$5  -  1 WINGS" + vbCrLf
    Public Const appetizer7s As String = "$5  -  1 WINGS" + vbCrLf
    Public Const entree1s As String = "$8  -  1 HONEY BBQ" + vbCrLf
    Public Const entree2s As String = "$7  -  1 TURKEY BLT" + vbCrLf
    Public Const entree3s As String = "$7  -  1 BACON BURGER" + vbCrLf
    Public Const desser1s As String = "$3  -  1 ICE CREAM" + vbCrLf


End Class
