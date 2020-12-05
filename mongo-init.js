db.createUser(
    {
        user: "MyUser",
        pwd: "MyPassword",
        roles: [
            {
                role: "readWrite",
                db: "MyDb"
            }
        ]
    }
);