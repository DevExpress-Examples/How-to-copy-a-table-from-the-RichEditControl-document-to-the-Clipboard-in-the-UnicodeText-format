﻿Namespace RichEditCustomCopyPaste
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.clipboardBar1 = New DevExpress.XtraRichEdit.UI.ClipboardBar()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.showFontFormItem1 = New DevExpress.XtraRichEdit.UI.ShowFontFormItem()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.showParagraphFormItem1 = New DevExpress.XtraRichEdit.UI.ShowParagraphFormItem()
            Me.changeStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeStyleItem()
            Me.repositoryItemRichEditStyleEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(Me.components)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.clipboardBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.cutItem1, Me.copyItem1, Me.pasteItem1, Me.pasteSpecialItem1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.changeFontColorItem1, Me.changeFontBackColorItem1, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.toggleTextCaseItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.clearFormattingItem1, Me.showFontFormItem1, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.toggleShowWhitespaceItem1, Me.showParagraphFormItem1, Me.changeStyleItem1, Me.findItem1, Me.replaceItem1})
            Me.barManager1.MaxItemId = 56
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemRichEditStyleEdit1})
            ' 
            ' clipboardBar1
            ' 
            Me.clipboardBar1.Control = Me.richEditControl1
            Me.clipboardBar1.DockCol = 0
            Me.clipboardBar1.DockRow = 0
            Me.clipboardBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.clipboardBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.cutItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.copyItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pasteItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pasteSpecialItem1) _
            })
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 9
            Me.cutItem1.ImageOptions.Image = (CType(resources.GetObject("cutItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.cutItem1.ImageOptions.LargeImage = (CType(resources.GetObject("cutItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 10
            Me.copyItem1.ImageOptions.Image = (CType(resources.GetObject("copyItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.copyItem1.ImageOptions.LargeImage = (CType(resources.GetObject("copyItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 11
            Me.pasteItem1.ImageOptions.Image = (CType(resources.GetObject("pasteItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.pasteItem1.ImageOptions.LargeImage = (CType(resources.GetObject("pasteItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Id = 12
            Me.pasteSpecialItem1.ImageOptions.Image = (CType(resources.GetObject("pasteSpecialItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.pasteSpecialItem1.ImageOptions.LargeImage = (CType(resources.GetObject("pasteSpecialItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.barDockControlTop.Size = New System.Drawing.Size(855, 31)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 653)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.barDockControlBottom.Size = New System.Drawing.Size(855, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 622)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(855, 31)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 622)
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 13
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 14
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 31)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.richEditControl1.MenuManager = Me.barManager1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(855, 622)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 15
            Me.changeFontColorItem1.ImageOptions.Image = (CType(resources.GetObject("changeFontColorItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.changeFontColorItem1.ImageOptions.LargeImage = (CType(resources.GetObject("changeFontColorItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontBackColorItem1
            ' 
            Me.changeFontBackColorItem1.Id = 16
            Me.changeFontBackColorItem1.ImageOptions.Image = (CType(resources.GetObject("changeFontBackColorItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.changeFontBackColorItem1.ImageOptions.LargeImage = (CType(resources.GetObject("changeFontBackColorItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.changeFontBackColorItem1.Name = "changeFontBackColorItem1"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Id = 17
            Me.toggleFontBoldItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontBoldItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontBoldItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontBoldItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Id = 18
            Me.toggleFontItalicItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontItalicItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontItalicItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontItalicItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Id = 19
            Me.toggleFontUnderlineItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontUnderlineItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontUnderlineItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Id = 20
            Me.toggleFontDoubleUnderlineItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontDoubleUnderlineItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Id = 21
            Me.toggleFontStrikeoutItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontStrikeoutItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontStrikeoutItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Id = 22
            Me.toggleFontDoubleStrikeoutItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontDoubleStrikeoutItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Id = 23
            Me.toggleFontSuperscriptItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontSuperscriptItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontSuperscriptItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Id = 24
            Me.toggleFontSubscriptItem1.ImageOptions.Image = (CType(resources.GetObject("toggleFontSubscriptItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleFontSubscriptItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            Me.changeTextCaseItem1.Id = 25
            Me.changeTextCaseItem1.ImageOptions.Image = (CType(resources.GetObject("changeTextCaseItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.changeTextCaseItem1.ImageOptions.LargeImage = (CType(resources.GetObject("changeTextCaseItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1) _
            })
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            Me.makeTextUpperCaseItem1.Id = 26
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            Me.makeTextLowerCaseItem1.Id = 27
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            Me.toggleTextCaseItem1.Id = 28
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Id = 29
            Me.fontSizeIncreaseItem1.ImageOptions.Image = (CType(resources.GetObject("fontSizeIncreaseItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.ImageOptions.LargeImage = (CType(resources.GetObject("fontSizeIncreaseItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Id = 30
            Me.fontSizeDecreaseItem1.ImageOptions.Image = (CType(resources.GetObject("fontSizeDecreaseItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.ImageOptions.LargeImage = (CType(resources.GetObject("fontSizeDecreaseItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Id = 31
            Me.clearFormattingItem1.ImageOptions.Image = (CType(resources.GetObject("clearFormattingItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.clearFormattingItem1.ImageOptions.LargeImage = (CType(resources.GetObject("clearFormattingItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' showFontFormItem1
            ' 
            Me.showFontFormItem1.Id = 32
            Me.showFontFormItem1.ImageOptions.Image = (CType(resources.GetObject("showFontFormItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.showFontFormItem1.ImageOptions.LargeImage = (CType(resources.GetObject("showFontFormItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.showFontFormItem1.Name = "showFontFormItem1"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Id = 33
            Me.toggleParagraphAlignmentLeftItem1.ImageOptions.Image = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleParagraphAlignmentLeftItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Id = 34
            Me.toggleParagraphAlignmentCenterItem1.ImageOptions.Image = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleParagraphAlignmentCenterItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Id = 35
            Me.toggleParagraphAlignmentRightItem1.ImageOptions.Image = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleParagraphAlignmentRightItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Id = 36
            Me.toggleParagraphAlignmentJustifyItem1.ImageOptions.Image = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleParagraphAlignmentJustifyItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            Me.changeParagraphLineSpacingItem1.Id = 37
            Me.changeParagraphLineSpacingItem1.ImageOptions.Image = (CType(resources.GetObject("changeParagraphLineSpacingItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.changeParagraphLineSpacingItem1.ImageOptions.LargeImage = (CType(resources.GetObject("changeParagraphLineSpacingItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1) _
            })
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            Me.setSingleParagraphSpacingItem1.Id = 38
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            Me.setSesquialteralParagraphSpacingItem1.Id = 39
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            Me.setDoubleParagraphSpacingItem1.Id = 40
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            Me.showLineSpacingFormItem1.Id = 41
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            Me.addSpacingBeforeParagraphItem1.Id = 42
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            Me.removeSpacingBeforeParagraphItem1.Id = 43
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            Me.addSpacingAfterParagraphItem1.Id = 44
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            Me.removeSpacingAfterParagraphItem1.Id = 45
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Id = 46
            Me.toggleBulletedListItem1.ImageOptions.Image = (CType(resources.GetObject("toggleBulletedListItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleBulletedListItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleBulletedListItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Id = 47
            Me.toggleNumberingListItem1.ImageOptions.Image = (CType(resources.GetObject("toggleNumberingListItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleNumberingListItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleNumberingListItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Id = 48
            Me.toggleMultiLevelListItem1.ImageOptions.Image = (CType(resources.GetObject("toggleMultiLevelListItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleMultiLevelListItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Id = 49
            Me.decreaseIndentItem1.ImageOptions.Image = (CType(resources.GetObject("decreaseIndentItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.decreaseIndentItem1.ImageOptions.LargeImage = (CType(resources.GetObject("decreaseIndentItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Id = 50
            Me.increaseIndentItem1.ImageOptions.Image = (CType(resources.GetObject("increaseIndentItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.increaseIndentItem1.ImageOptions.LargeImage = (CType(resources.GetObject("increaseIndentItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Id = 51
            Me.toggleShowWhitespaceItem1.ImageOptions.Image = (CType(resources.GetObject("toggleShowWhitespaceItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.ImageOptions.LargeImage = (CType(resources.GetObject("toggleShowWhitespaceItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' showParagraphFormItem1
            ' 
            Me.showParagraphFormItem1.Id = 52
            Me.showParagraphFormItem1.ImageOptions.Image = (CType(resources.GetObject("showParagraphFormItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.showParagraphFormItem1.ImageOptions.LargeImage = (CType(resources.GetObject("showParagraphFormItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.showParagraphFormItem1.Name = "showParagraphFormItem1"
            ' 
            ' changeStyleItem1
            ' 
            Me.changeStyleItem1.Edit = Me.repositoryItemRichEditStyleEdit1
            Me.changeStyleItem1.Id = 53
            Me.changeStyleItem1.Name = "changeStyleItem1"
            ' 
            ' repositoryItemRichEditStyleEdit1
            ' 
            Me.repositoryItemRichEditStyleEdit1.AutoHeight = False
            Me.repositoryItemRichEditStyleEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditStyleEdit1.Control = Me.richEditControl1
            Me.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 54
            Me.findItem1.ImageOptions.Image = (CType(resources.GetObject("findItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.findItem1.ImageOptions.LargeImage = (CType(resources.GetObject("findItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 55
            Me.replaceItem1.ImageOptions.Image = (CType(resources.GetObject("replaceItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.replaceItem1.ImageOptions.LargeImage = (CType(resources.GetObject("replaceItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' richEditBarController1
            ' 
            Me.richEditBarController1.BarItems.Add(Me.cutItem1)
            Me.richEditBarController1.BarItems.Add(Me.copyItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteItem1)
            Me.richEditBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeFontBackColorItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.richEditBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showFontFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.richEditBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.richEditBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.richEditBarController1.BarItems.Add(Me.showParagraphFormItem1)
            Me.richEditBarController1.BarItems.Add(Me.changeStyleItem1)
            Me.richEditBarController1.BarItems.Add(Me.findItem1)
            Me.richEditBarController1.BarItems.Add(Me.replaceItem1)
            Me.richEditBarController1.Control = Me.richEditControl1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(855, 653)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.Name = "Form1"
            Me.Text = "Copy the table and paste it into Notepad or MS Office Excel"
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemRichEditStyleEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private clipboardBar1 As DevExpress.XtraRichEdit.UI.ClipboardBar
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontBackColorItem
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private showFontFormItem1 As DevExpress.XtraRichEdit.UI.ShowFontFormItem
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private showParagraphFormItem1 As DevExpress.XtraRichEdit.UI.ShowParagraphFormItem
        Private changeStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeStyleItem
        Private repositoryItemRichEditStyleEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
    End Class
End Namespace

