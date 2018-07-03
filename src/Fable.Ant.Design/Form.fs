namespace Fable.AntD

open Fable.Import
open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import.React

/// import declarations for `Form` and its nested components.
/// For more information, refer to the [official documentation](https://ant.design/components/form/)
[<RequireQualifiedAccess>]
module Form =

    [<StringEnum>]
    type ValidationStatus = Success | Warning | Error | Validating

    type FormItemProps =
      /// Used with label, whether to display : after label text. Default = true
      | Colon of bool
      /// The extra prompt message. It is similar to help.
      /// Usage example: to display error message and prompt message at the same time.
      | Extra of U2<string,ReactNode>
      /// Used with validateStatus, this option specifies the validation status icon.
      /// Recommended to be used only with Input. Default = false
      | HasFeedback of bool
      /// The prompt message. If not provided, the prompt message will be generated by the validation rule.
      | Help of U2<string,ReactNode>
      /// Label text
      | Label of U2<string,ReactNode>
      /// The layout of label.
      /// You can set span offset to something like `{span: 3, offset: 12}`
      /// or `sm: {span: 3, offset: 12}` same as with `<Col>`
      | LabelCol of obj
      /// Whether provided or not, it will be generated by the validation rule.
      /// Default = false
      | Required of bool
      /// The validation status. If not provided, it will be generated by validation rule.
      | ValidationStatus of ValidationStatus
      /// The layout for input controls, same as labelCol
      | WrapperCol of obj
      interface Fable.Helpers.React.Props.IProp

    let inline formItem (props: IProp list) (children: React.ReactElement list): React.ReactElement =
       ofImport "Form.Item" "antd" (keyValueList CaseRules.LowerFirst props) children

    [<StringEnum>]
    type FormLayout = Horizontal | Vertical | Inline

    type FormProps =
      /// Hide required mark of all form items. Default = false
      | HideRequiredMark of bool
      /// Define form layout(Support after 2.8)
      | Layout of FormLayout
      | OnSubmit of FormEventHandler
      interface Fable.Helpers.React.Props.IProp

    let inline form (props: IProp list) (children: React.ReactElement list): React.ReactElement =
       ofImport "Form" "antd" (keyValueList CaseRules.LowerFirst props) children