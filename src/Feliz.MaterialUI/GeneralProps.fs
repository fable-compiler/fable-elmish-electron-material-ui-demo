namespace Feliz.MaterialUI

open Fable.Core
open Feliz

[<Erase>]
type prop =

  static member inline className(value: IClassName) = Interop.mkAttr "className" (unbox<string> value)
