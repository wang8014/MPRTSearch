declare @find int;
select @find=100
while (@find<=140)
begin
    select @find = @find + 1
    --print 'this.Property(p => p.Column' + substring(convert(nvarchar(3),@find),2,2)+ ').IsRequired().HasMaxLength(255).HasColumnName("Column' + substring(convert(nvarchar(3),@find),2,2)+ '").IsUnicode(true);'
    
	--print 'public string Column' + substring(convert(nvarchar(3),@find),2,2)+ 'DisplayName { get; set; }' 
    --print 'public string Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value { get; set; }' 
    
    --print 'rtn.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'DisplayName = "Column' + substring(convert(nvarchar(3),@find),2,2)+ 'DisplayName";'
    --print 'rtn.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value = searchDataSet.Column' + substring(convert(nvarchar(3),@find),2,2) +';' 

    -- print 'this.Property(p => p.Column' + substring(convert(nvarchar(3),@find),2,2)+ ').IsOptional().HasMaxLength(255).HasColumnName("Column' + substring(convert(nvarchar(3),@find),2,2)+ '").IsUnicode(true);'
	--print '<b>@Model.GetColumnName(Model.ListSearchDataSet[searchDataSetIndex].TypeID, ' + substring(convert(nvarchar(3),@find),2,2)+ '):</b>@(Model.ListSearchDataSet[searchDataSetIndex].Column' + substring(convert(nvarchar(3),@find),2,2)+ '==null?"":Model.ListSearchDataSet[searchDataSetIndex].Column' + substring(convert(nvarchar(3),@find),2,2)+ '.ToString());'
            
			
	--print 'columnName = GetColumnName(data.TypeID, ' + substring(convert(nvarchar(3),@find),2,2)+ ');'
 --   print 'columnValue = data.Column' + substring(convert(nvarchar(3),@find),2,2)+ ';'
 --   print 'if ((columnName != null) && (columnName != "[okänd kolumn]"))'
 --   print '{'
 --   print '//det finns kolumnen'
 --   print 'rtn = rtn + "<b>" + columnName + ":</b>" + columnValue == null ? "" : columnValue;'
 --   print '}'                   
	
	
	--print 'public string Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name { get; set; }'
	--print 'public string Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value { get; set; }'
	--print 'or column' + substring(convert(nvarchar(3),@find),2,2)+ ' like ''%TV%'''

	print 'if ((Model.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name != null) && (Model.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name != "[okänd kolumn]"))'
    print '                    {'
    print '                        <tr>'
    print '                            <td class="col-xs-4">'
    print '                                <h4>@Model.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name:</h4>'
    print '                            </td>'
    print '                            <td class="col-xs-8">'
    print '                                <h5>@(Model.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value == null ? "" : Model.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value)</h5>'
    print '                            </td>'
    print '                        </tr>'
    print '                    }'


	--print	'ColumnTable columnTable = ListColumnTable.Find(p => (p.TypeID == data.TypeID) &&(p.Sorting == ' + substring(convert(nvarchar(3),@find),2,2)+ ') );'
 --   print	'            if (columnTable != null)'
 --   print	'            {'
 --   print	'                columnName = columnTable.ColumnName;'
 --   print	'                detailViewModel.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name = columnName;'
 --   print	'                detailViewModel.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value = data.Column' + substring(convert(nvarchar(3),@find),2,2)+ ';'
 --   print	'            }'
 --   print	'            else'
 --   print	'            {'
 --   print	'                detailViewModel.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Name = "[okänd kolumn]";'
 --   print	'                detailViewModel.Column' + substring(convert(nvarchar(3),@find),2,2)+ 'Value = data.Column' + substring(convert(nvarchar(3),@find),2,2)+ ';'
 --   print	'            }'

end 
