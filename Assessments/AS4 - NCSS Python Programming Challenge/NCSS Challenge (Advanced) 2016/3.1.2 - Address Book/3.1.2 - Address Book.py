import csv, sys
with open('addresses.csv') as f:
  reader = csv.DictReader(f)
  s = input("Query: ")
  writer = csv.DictWriter(sys.stdout, fieldnames=reader.fieldnames, dialect='unix')
  writer.writeheader()
  for entry in reader:
    _ = True
    for query in s.split(','):
      key, value = query.split("=",1)
      if entry[key] != value: _ = False
    if _: writer.writerow(entry)