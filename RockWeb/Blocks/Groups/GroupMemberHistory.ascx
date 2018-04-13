﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GroupMemberHistory.ascx.cs" Inherits="RockWeb.Blocks.Groups.GroupMemberHistory" %>

<asp:UpdatePanel ID="upnlContent" runat="server">
    <ContentTemplate>
        <asp:HiddenField ID="hfGroupId" runat="server" />
        <asp:HiddenField ID="hfGroupMemberId" runat="server" />
        <div class="panel panel-block">
            <div class="panel-heading">
                <h1 class="panel-title">
                    <i class="fa fa-history"></i>
                    <asp:Literal ID="lReadOnlyTitle" runat="server" />
                </h1>
            </div>

            <asp:Panel ID="pnlMembers" runat="server" Visible="false">
                <div class="panel panel-block">

                    <div class="panel-heading clearfix">
                        <h1 class="panel-title pull-left">
                            <i class="fa fa-users"></i>
                            <asp:Literal ID="lHeading" runat="server" Text="Historical Group Members" />
                        </h1>
                    </div>

                    <div class="grid grid-panel">
                        <Rock:GridFilter ID="gfGroupMembers" runat="server" OnDisplayFilterValue="gfGroupMembers_DisplayFilterValue" OnClearFilterClick="gfGroupMembers_ClearFilterClick" OnApplyFilterClick="gfGroupMembers_ApplyFilterClick">
                            <Rock:RockTextBox ID="tbFirstName" runat="server" Label="First Name" />
                            <Rock:RockTextBox ID="tbLastName" runat="server" Label="Last Name" />
                            <Rock:SlidingDateRangePicker ID="sdrDateAdded" runat="server" Label="Date Added" EnabledSlidingDateRangeTypes="Previous, Last, Current, DateRange" />
                            <Rock:SlidingDateRangePicker ID="sdrDateRemoved" runat="server" Label="Date Removed" EnabledSlidingDateRangeTypes="Previous, Last, Current, DateRange" />
                            <Rock:RockCheckBoxList ID="cblRole" runat="server" Label="Last Role" DataTextField="Name" DataValueField="Id" RepeatDirection="Horizontal" />
                            <Rock:RockCheckBoxList ID="cblGroupMemberStatus" runat="server" Label="Last Status" RepeatDirection="Horizontal"  />
                        </Rock:GridFilter>
                        <Rock:Grid ID="gGroupMembers" runat="server" AllowSorting="true" DataKeyNames="Id" CssClass="js-grid-group-members" OnRowSelected="gGroupMembers_RowSelected">
                            <Columns>
                                <Rock:PersonField DataField="Person" HeaderText="Name" SortExpression="Person.LastName,Person.NickName" />
                                <Rock:DateField DataField="DateTimeAdded" HeaderText="Date Added" SortExpression="DateTimeAdded" ItemStyle-HorizontalAlign="Left" />
                                <Rock:DateField DataField="ArchivedDateTime" HeaderText="Date Removed" SortExpression="ArchivedDateTime" ItemStyle-HorizontalAlign="Left" />
                                <Rock:RockBoundField DataField="GroupRole.Name" HeaderText="Last Role" SortExpression="GroupRole.Name" />
                                <Rock:EnumField DataField="GroupMemberStatus" HeaderText="Last Status" SortExpression="GroupMemberStatus" />
                            </Columns>
                        </Rock:Grid>
                    </div>

                </div>
            </asp:Panel>

            <div class="panel-body">
                <asp:Literal ID="lTimelineHtml" runat="server" />
            </div>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>