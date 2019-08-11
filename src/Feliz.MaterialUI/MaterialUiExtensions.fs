[<AutoOpen>]
module Feliz.MaterialUI.MaterialUIExtensions

open Fable.Core.JsInterop
open Fable.MaterialUI
open Feliz


type Themes.IBreakpoints with

  member this.up_xs styles =
    style.inner (this.up !^MaterialSize.Xs) styles
  member this.up_sm styles =
    style.inner (this.up !^MaterialSize.Sm) styles
  member this.up_md styles =
    style.inner (this.up !^MaterialSize.Md) styles
  member this.up_lg styles =
    style.inner (this.up !^MaterialSize.Lg) styles
  member this.up_xl styles =
    style.inner (this.up !^MaterialSize.Xl) styles

  member this.down_xs styles =
    style.inner (this.down !^MaterialSize.Xs) styles
  member this.down_sm styles =
    style.inner (this.down !^MaterialSize.Sm) styles
  member this.down_md styles =
    style.inner (this.down !^MaterialSize.Md) styles
  member this.down_lg styles =
    style.inner (this.down !^MaterialSize.Lg) styles
  member this.down_xl styles =
    style.inner (this.down !^MaterialSize.Xl) styles

  member this.only_xs styles =
    style.inner (this.only MaterialSize.Xs) styles
  member this.only_sm styles =
    style.inner (this.only MaterialSize.Sm) styles
  member this.only_md styles =
    style.inner (this.only MaterialSize.Md) styles
  member this.only_lg styles =
    style.inner (this.only MaterialSize.Lg) styles
  member this.only_xl styles =
    style.inner (this.only MaterialSize.Xl) styles

  member this.between_xs_sm styles =
    style.inner (this.between(MaterialSize.Xs, MaterialSize.Sm)) styles
  member this.between_xs_md styles =
    style.inner (this.between(MaterialSize.Xs, MaterialSize.Md)) styles
  member this.between_xs_lg styles =
    style.inner (this.between(MaterialSize.Xs, MaterialSize.Lg)) styles
  member this.between_xs_xl styles =
    style.inner (this.between(MaterialSize.Xs, MaterialSize.Xl)) styles
  member this.between_sm_md styles =
    style.inner (this.between(MaterialSize.Sm, MaterialSize.Md)) styles
  member this.between_sm_lg styles =
    style.inner (this.between(MaterialSize.Sm, MaterialSize.Lg)) styles
  member this.between_sm_xl styles =
    style.inner (this.between(MaterialSize.Sm, MaterialSize.Xl)) styles
  member this.between_md_lg styles =
    style.inner (this.between(MaterialSize.Md, MaterialSize.Lg)) styles
  member this.between_md_xl styles =
    style.inner (this.between(MaterialSize.Md, MaterialSize.Xl)) styles
  member this.between_lg_xl styles =
    style.inner (this.between(MaterialSize.Lg, MaterialSize.Xl)) styles
