declare @find int;
select @find=100
while (@find<=140)
begin
    select @find = @find + 1
    print 'this.Property(p => p.Column' + substring(convert(nvarchar(3),@find),2,2)+ ').IsRequired().HasMaxLength(255).HasColumnName("Column' + substring(convert(nvarchar(3),@find),2,2)+ '").IsUnicode(true);'
end 
