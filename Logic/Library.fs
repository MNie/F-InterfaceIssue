namespace Logic

    type IInterface =
        abstract member Some: string -> string
        
    type SomeClass() =
        interface IInterface with
            member this.Some (a: string) = "dd"
