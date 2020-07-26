# MSAPhase1-Database
Endpoint URL: https://msaphase1databases.azurewebsites.net/index.html.

Screenshots found in Screenshots folder. 

**Address CRUD**:

- C: POST
- R: GET
- U: PUT requires both correct studentid and addressid to be given due to one to many relationship
- D: Delete

**Student CRUD**:

- C: POST creates address if one is given.
- R: GET
- U: PUT updates student and address if the correct studentids and addressids are given. If the addressId cannot be found for the student, a new address is created. 
- D: Delete deletes both student and its addresses
