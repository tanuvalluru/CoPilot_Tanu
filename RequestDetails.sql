-- BEGIN: /workspaces/CoPilot_Tanu/RequestDetails.sql

CREATE TABLE IF NOT EXISTS RequestDetails (
    Id INTEGER PRIMARY KEY,
    RequestType VARCHAR,
    Description VARCHAR,
    ExpectedDate VARCHAR,
    UserId INTEGER,
    FOREIGN KEY (UserId) REFERENCES User(Id)
);

-- END: /workspaces/CoPilot_Tanu/RequestDetails.sql
