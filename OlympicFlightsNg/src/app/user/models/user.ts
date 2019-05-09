export class User{

    public userId:string;
    public newPassword:string;
    public userRole:string;
    constructor(
        public userName: string,
        public userEmail: string,
        public userPassword: string
    ) {

    };
}
