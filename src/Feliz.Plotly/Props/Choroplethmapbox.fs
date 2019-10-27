namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type choroplethmapbox =
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkChoroplethmapboxAttr "name" value
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkChoroplethmapboxAttr "uid" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkChoroplethmapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkChoroplethmapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkChoroplethmapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkChoroplethmapboxAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkChoroplethmapboxAttr "ids" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkChoroplethmapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkChoroplethmapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkChoroplethmapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkChoroplethmapboxAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkChoroplethmapboxAttr "customdata" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkChoroplethmapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkChoroplethmapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkChoroplethmapboxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkChoroplethmapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkChoroplethmapboxAttr "selectedpoints" (values |> Array.ofSeq)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkChoroplethmapboxAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkChoroplethmapboxAttr "selectedpoints" (values |> Array.ofSeq)
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkChoroplethmapboxAttr "hoverlabel" (createObj !!properties)
    static member inline stream (properties: #IStreamProperty list) = Interop.mkChoroplethmapboxAttr "stream" (createObj !!properties)
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkChoroplethmapboxAttr "transforms" (createObj !!properties)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkChoroplethmapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkChoroplethmapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkChoroplethmapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkChoroplethmapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkChoroplethmapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkChoroplethmapboxAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkChoroplethmapboxAttr "uirevision" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (value: bool) = Interop.mkChoroplethmapboxAttr "locations" (value |> Array.singleton)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (value: string) = Interop.mkChoroplethmapboxAttr "locations" (value |> Array.singleton)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<string>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (value: int) = Interop.mkChoroplethmapboxAttr "locations" (value |> Array.singleton)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<int>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (value: float) = Interop.mkChoroplethmapboxAttr "locations" (value |> Array.singleton)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<float>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<seq<bool>>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<bool list>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<bool []>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<seq<string>>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<string list>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<string []>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<seq<int>>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<int list>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<int []>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<seq<float>>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<float list>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets which features found in *geojson* to plot using their feature `id` field.
    static member inline locations (values: seq<float []>) = Interop.mkChoroplethmapboxAttr "locations" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (value: bool) = Interop.mkChoroplethmapboxAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (value: string) = Interop.mkChoroplethmapboxAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<string>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (value: int) = Interop.mkChoroplethmapboxAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<int>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (value: float) = Interop.mkChoroplethmapboxAttr "z" (value |> Array.singleton)
    /// Sets the color values.
    static member inline z (values: seq<float>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<seq<bool>>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<bool list>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<bool []>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<seq<string>>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<string list>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<string []>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<seq<int>>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<int list>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<int []>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<seq<float>>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<float list>) = Interop.mkChoroplethmapboxAttr "z" (values |> Seq.map Array.ofSeq |> Array.ofSeq)
    /// Sets the color values.
    static member inline z (values: seq<float []>) = Interop.mkChoroplethmapboxAttr "z" (values |> Array.ofSeq)
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (value: bool) = Interop.mkChoroplethmapboxAttr "geojson" value
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (values: seq<bool>) = Interop.mkChoroplethmapboxAttr "geojson" (values |> Array.ofSeq)
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (value: string) = Interop.mkChoroplethmapboxAttr "geojson" value
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (values: seq<string>) = Interop.mkChoroplethmapboxAttr "geojson" (values |> Array.ofSeq)
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (value: int) = Interop.mkChoroplethmapboxAttr "geojson" value
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (values: seq<int>) = Interop.mkChoroplethmapboxAttr "geojson" (values |> Array.ofSeq)
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (value: float) = Interop.mkChoroplethmapboxAttr "geojson" value
    /// Sets the GeoJSON data associated with this trace. Can be set as a valid GeoJSON object or as URL string Note that we only accept GeoJSON of type *FeatureCollection* and *Feature* with geometries of type *Polygon* and *MultiPolygon*.
    static member inline geojson (values: seq<float>) = Interop.mkChoroplethmapboxAttr "geojson" (values |> Array.ofSeq)
    /// Determines if the choropleth polygons will be inserted before the layer with the specified ID. By default, choroplethmapbox traces are placed above the water layers. If set to '', the layer will be inserted above every existing layer.
    static member inline below (value: string) = Interop.mkChoroplethmapboxAttr "below" value
    /// Sets the text elements associated with each location.
    static member inline text (value: string) = Interop.mkChoroplethmapboxAttr "text" value
    /// Sets the text elements associated with each location.
    static member inline text (values: seq<string>) = Interop.mkChoroplethmapboxAttr "text" (values |> Array.ofSeq)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkChoroplethmapboxAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkChoroplethmapboxAttr "hovertext" (values |> Array.ofSeq)
    static member inline marker (properties: #IMarkerProperty list) = Interop.mkChoroplethmapboxAttr "marker" (createObj !!properties)
    static member inline selected (properties: #ISelectedProperty list) = Interop.mkChoroplethmapboxAttr "selected" (createObj !!properties)
    static member inline unselected (properties: #IUnselectedProperty list) = Interop.mkChoroplethmapboxAttr "unselected" (createObj !!properties)
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #IChoroplethmapboxProperty list) = Interop.mkChoroplethmapboxAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `properties` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (value: string) = Interop.mkChoroplethmapboxAttr "hovertemplate" value
    /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `properties` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
    static member inline hovertemplate (values: seq<string>) = Interop.mkChoroplethmapboxAttr "hovertemplate" (values |> Array.ofSeq)
    /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
    static member inline zauto (value: bool) = Interop.mkChoroplethmapboxAttr "zauto" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: int) = Interop.mkChoroplethmapboxAttr "zmin" value
    /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
    static member inline zmin (value: float) = Interop.mkChoroplethmapboxAttr "zmin" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: int) = Interop.mkChoroplethmapboxAttr "zmax" value
    /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
    static member inline zmax (value: float) = Interop.mkChoroplethmapboxAttr "zmax" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: int) = Interop.mkChoroplethmapboxAttr "zmid" value
    /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
    static member inline zmid (value: float) = Interop.mkChoroplethmapboxAttr "zmid" value
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (value: string) = Interop.mkChoroplethmapboxAttr "colorscale" (value |> Array.singleton)
    /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
    static member inline colorscale (values: seq<string>) = Interop.mkChoroplethmapboxAttr "colorscale" (values |> Array.ofSeq)
    /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
    static member inline autocolorscale (value: bool) = Interop.mkChoroplethmapboxAttr "autocolorscale" value
    /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
    static member inline reversescale (value: bool) = Interop.mkChoroplethmapboxAttr "reversescale" value
    /// Determines whether or not a colorbar is displayed for this trace.
    static member inline showscale (value: bool) = Interop.mkChoroplethmapboxAttr "showscale" value
    static member inline colorbar (properties: #IColorbarProperty list) = Interop.mkChoroplethmapboxAttr "colorbar" (createObj !!properties)
    /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
    static member inline coloraxis (value: string) = Interop.mkChoroplethmapboxAttr "coloraxis" value
    /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
    static member inline subplot (value: string) = Interop.mkChoroplethmapboxAttr "subplot" value
    /// Sets the source reference on plot.ly for  ids .
    static member inline idssrc (value: string) = Interop.mkChoroplethmapboxAttr "idssrc" value
    /// Sets the source reference on plot.ly for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkChoroplethmapboxAttr "customdatasrc" value
    /// Sets the source reference on plot.ly for  meta .
    static member inline metasrc (value: string) = Interop.mkChoroplethmapboxAttr "metasrc" value
    /// Sets the source reference on plot.ly for  locations .
    static member inline locationssrc (value: string) = Interop.mkChoroplethmapboxAttr "locationssrc" value
    /// Sets the source reference on plot.ly for  z .
    static member inline zsrc (value: string) = Interop.mkChoroplethmapboxAttr "zsrc" value
    /// Sets the source reference on plot.ly for  text .
    static member inline textsrc (value: string) = Interop.mkChoroplethmapboxAttr "textsrc" value
    /// Sets the source reference on plot.ly for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkChoroplethmapboxAttr "hovertextsrc" value
    /// Sets the source reference on plot.ly for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkChoroplethmapboxAttr "hoverinfosrc" value
    /// Sets the source reference on plot.ly for  hovertemplate .
    static member inline hovertemplatesrc (value: string) = Interop.mkChoroplethmapboxAttr "hovertemplatesrc" value

[<AutoOpen>]
module choroplethmapbox =
    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkChoroplethmapboxAttr "visible" "legendonly"
        static member inline false' = Interop.mkChoroplethmapboxAttr "visible" "false"
        static member inline true' = Interop.mkChoroplethmapboxAttr "visible" "true"

    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkChoroplethmapboxAttr "hoverinfo" "all"
        static member inline none = Interop.mkChoroplethmapboxAttr "hoverinfo" "none"
        static member inline skip = Interop.mkChoroplethmapboxAttr "hoverinfo" "skip"
        static member inline location = Interop.mkChoroplethmapboxAttr "hoverinfo" "location"
        static member inline name = Interop.mkChoroplethmapboxAttr "hoverinfo" "name"
        static member inline text = Interop.mkChoroplethmapboxAttr "hoverinfo" "text"
        static member inline z = Interop.mkChoroplethmapboxAttr "hoverinfo" "z"

