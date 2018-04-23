@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "DocumentViewer"
                                      settings.CallbackRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerPartial"
                                      }
                                      settings.ExportRouteValues = New With {
                                          .Controller = "Home",
                                          .Action = "DocumentViewerPartialExport"
                                      }
                                      settings.Report = CType(Model, XtraReport)
                                      settings.SetCustomParameter("CategoryID", Sub(parameter)
                                                                                    Dim propertiesEdit As ComboBoxProperties = New ComboBoxProperties()
                                                                                    parameter.PropertiesEdit = propertiesEdit
         
                                                                                    Dim dataContext As E5053.Models.NWINDEntities = New E5053.Models.NWINDEntities()
                                                                                    propertiesEdit.ValueField = "CategoryID"
                                                                                    propertiesEdit.TextField = "CategoryName"
                                                                                    propertiesEdit.ValueType = GetType(Integer)
                                                                                    propertiesEdit.DataSource = From category In dataContext.Categories
                                                                                                                Select category
                                                                                End Sub)
                                  End Sub).GetHtml()
