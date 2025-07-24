// To parse this data:
//
//   import { Convert } from "./file";
//
//   const iUsers = Convert.toIUsers(json);

export interface IUsers {
    id:         number;
    firstName:  string;
    lastName:   string;
    maidenName: string;
    age:        number;
    gender:     Gender;
    email:      string;
    phone:      string;
    username:   string;
    password:   string;
    birthDate:  string;
    image:      string;
    bloodGroup: BloodGroup;
    height:     number;
    weight:     number;
    eyeColor:   EyeColor;
    hair:       Hair;
    ip:         string;
    address:    Address;
    macAddress: string;
    university: string;
    bank:       Bank;
    company:    Company;
    ein:        string;
    ssn:        string;
    userAgent:  string;
    crypto:     Crypto;
    role:       Role;
}

export interface Address {
    address:     string;
    city:        City;
    state:       string;
    stateCode:   string;
    postalCode:  string;
    coordinates: Coordinates;
    country:     Country;
}

export enum City {
    Austin = "Austin",
    Charlotte = "Charlotte",
    Chicago = "Chicago",
    Columbus = "Columbus",
    Dallas = "Dallas",
    Denver = "Denver",
    FortWorth = "Fort Worth",
    Houston = "Houston",
    Indianapolis = "Indianapolis",
    Jacksonville = "Jacksonville",
    LosAngeles = "Los Angeles",
    NewYork = "New York",
    Philadelphia = "Philadelphia",
    Phoenix = "Phoenix",
    SanAntonio = "San Antonio",
    SanDiego = "San Diego",
    SanFrancisco = "San Francisco",
    SanJose = "San Jose",
    Seattle = "Seattle",
    Washington = "Washington",
}

export interface Coordinates {
    lat: number;
    lng: number;
}

export enum Country {
    UnitedStates = "United States",
}

export interface Bank {
    cardExpire: string;
    cardNumber: string;
    cardType:   string;
    currency:   Currency;
    iban:       string;
}

export enum Currency {
    Aud = "AUD",
    Brl = "BRL",
    CAD = "CAD",
    Cny = "CNY",
    Eur = "EUR",
    Gbp = "GBP",
    Inr = "INR",
    Jpy = "JPY",
    Nzd = "NZD",
    Pkr = "PKR",
    Sek = "SEK",
    Try = "TRY",
    Usd = "USD",
}

export enum BloodGroup {
    A = "A-",
    Ab = "AB+",
    B = "B+",
    BloodGroupA = "A+",
    BloodGroupAB = "AB-",
    BloodGroupB = "B-",
    BloodGroupO = "O+",
    O = "O-",
}

export interface Company {
    department: Department;
    name:       string;
    title:      string;
    address:    Address;
}

export enum Department {
    Accounting = "Accounting",
    BusinessDevelopment = "Business Development",
    Engineering = "Engineering",
    HumanResources = "Human Resources",
    Legal = "Legal",
    Marketing = "Marketing",
    ProductManagement = "Product Management",
    ResearchAndDevelopment = "Research and Development",
    Sales = "Sales",
    Services = "Services",
    Support = "Support",
    Training = "Training",
}

export interface Crypto {
    coin:    Coin;
    wallet:  Wallet;
    network: Network;
}

export enum Coin {
    Bitcoin = "Bitcoin",
}

export enum Network {
    EthereumERC20 = "Ethereum (ERC20)",
}

export enum Wallet {
    The0Xb9Fc2Fe63B2A6C003F1C324C3Bfa53259162181A = "0xb9fc2fe63b2a6c003f1c324c3bfa53259162181a",
}

export enum EyeColor {
    Amber = "Amber",
    Blue = "Blue",
    Brown = "Brown",
    Gray = "Gray",
    Green = "Green",
    Hazel = "Hazel",
    Red = "Red",
    Violet = "Violet",
}

export enum Gender {
    Female = "female",
    Male = "male",
}

export interface Hair {
    color: Color;
    type:  Type;
}

export enum Color {
    Black = "Black",
    Blonde = "Blonde",
    Blue = "Blue",
    Brown = "Brown",
    Gray = "Gray",
    Green = "Green",
    Purple = "Purple",
    Red = "Red",
    White = "White",
}

export enum Type {
    Curly = "Curly",
    Kinky = "Kinky",
    Straight = "Straight",
    Wavy = "Wavy",
}

export enum Role {
    Admin = "admin",
    Moderator = "moderator",
    User = "user",
}

// Converts JSON strings to/from your types
export class Convert {
    public static toIUsers(json: string): IUsers {
        return JSON.parse(json);
    }

    public static iUsersToJson(value: IUsers): string {
        return JSON.stringify(value);
    }

    public static toAddress(json: string): Address {
        return JSON.parse(json);
    }

    public static addressToJson(value: Address): string {
        return JSON.stringify(value);
    }

    public static toCoordinates(json: string): Coordinates {
        return JSON.parse(json);
    }

    public static coordinatesToJson(value: Coordinates): string {
        return JSON.stringify(value);
    }

    public static toBank(json: string): Bank {
        return JSON.parse(json);
    }

    public static bankToJson(value: Bank): string {
        return JSON.stringify(value);
    }

    public static toCompany(json: string): Company {
        return JSON.parse(json);
    }

    public static companyToJson(value: Company): string {
        return JSON.stringify(value);
    }

    public static toCrypto(json: string): Crypto {
        return JSON.parse(json);
    }

    public static cryptoToJson(value: Crypto): string {
        return JSON.stringify(value);
    }

    public static toHair(json: string): Hair {
        return JSON.parse(json);
    }

    public static hairToJson(value: Hair): string {
        return JSON.stringify(value);
    }
}
