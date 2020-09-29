# dotnetstudy

update data
/*Publisher publisher = _context.Publishers.FirstOrDefault();*/

/*publisher.PublsherName = " Egmont Books";*/

delete data
/*_context.Publishers.Remove(publisher);*/

save changes
/* _context.SaveChanges();*/

read data

add - migration < name blabla > will create a migration
update-database will add the table
remove migration will delete the last migration
update-database <name of the migration > will remove all the table created ater thhe stated migration but not the migration
script-migration will create sql scipt aoo all the thin done 