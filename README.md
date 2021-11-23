# RevitWPFFW
A Framework Template for Revit WPF Forms using MVVM and WPF Transaction Command Wrapper

### GENERAL INFORMATION
The template was developed based on input from the following sources:

### Class Organization, WPF and Ribbon Templates: 
Marko Koljancic Revit API Family Manager Video Series
  
https://www.linkedin.com/pulse/06-revit-api-family-manager-plugin-dockable-pane-wpf-koljancic?trk=portfolio_article-card_title
  
### WPF Wrapped Command:
Petr Mitev via The Building Coder Blog
  
https://thebuildingcoder.typepad.com/blog/2020/01/revit-wpf-add-ins-and-template.html
  
https://github.com/mitevpi/revit-wpf-template
  
### Automatic Selection Change Event:
"Dummy" ribbon QA Toolbar monitoring from 2020 Revit API Forum
  
https://forums.autodesk.com/t5/revit-api-forum/element-selection-changed-event-implementation-struggles/td-p/9229523

### Dialog service and styles require reference to MVVMToolkit, available here:  https://github.com/jtprichard/MVVMToolkit

### Revisions
11/23/21 - Updated main branch to include dialog service making dialogs accessible from RevitWPFFW.core.  Custom list dialog view and viewmodel examples incorporated. 

9/29/21 - Incorporated basic help file support.  Help files were developed with HelpnDoc.

9/28/21 - Refactored dockpanel viewmodels to associate with current Revit document.  Document Hash Code is visible for testing on views, and used to track the correct viewmodel.

6/2/21 - Template committed for public consumption.  My first publish, so please be kind!
  
