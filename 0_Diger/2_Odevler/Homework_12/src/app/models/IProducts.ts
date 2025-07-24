// To parse this data:
//
//   import { Convert } from "./file";
//
//   const iProducts = Convert.toIProducts(json);

export interface IProducts {
    id:                   number;
    title:                string;
    description:          string;
    category:             string;
    price:                number;
    discountPercentage:   number;
    rating:               number;
    stock:                number;
    tags:                 string[];
    brand?:               string;
    sku:                  string;
    weight:               number;
    dimensions:           Dimensions;
    warrantyInformation:  WarrantyInformation;
    shippingInformation:  ShippingInformation;
    availabilityStatus:   AvailabilityStatus;
    reviews:              Review[];
    returnPolicy:         ReturnPolicy;
    minimumOrderQuantity: number;
    meta:                 Meta;
    images:               string[];
    thumbnail:            string;
}

export enum AvailabilityStatus {
    InStock = "In Stock",
    LowStock = "Low Stock",
    OutOfStock = "Out of Stock",
}

export interface Dimensions {
    width:  number;
    height: number;
    depth:  number;
}

export interface Meta {
    createdAt: Date;
    updatedAt: Date;
    barcode:   string;
    qrCode:    string;
}

export enum ReturnPolicy {
    NoReturnPolicy = "No return policy",
    The30DaysReturnPolicy = "30 days return policy",
    The60DaysReturnPolicy = "60 days return policy",
    The7DaysReturnPolicy = "7 days return policy",
    The90DaysReturnPolicy = "90 days return policy",
}

export interface Review {
    rating:        number;
    comment:       Comment;
    date:          Date;
    reviewerName:  string;
    reviewerEmail: string;
}

export enum Comment {
    AwesomeProduct = "Awesome product!",
    DisappointingProduct = "Disappointing product!",
    ExcellentQuality = "Excellent quality!",
    FastShipping = "Fast shipping!",
    GreatProduct = "Great product!",
    GreatValueForMoney = "Great value for money!",
    HighlyImpressed = "Highly impressed!",
    HighlyRecommended = "Highly recommended!",
    NotAsDescribed = "Not as described!",
    NotWorthThePrice = "Not worth the price!",
    PoorQuality = "Poor quality!",
    VeryDisappointed = "Very disappointed!",
    VeryDissatisfied = "Very dissatisfied!",
    VeryHappyWithMyPurchase = "Very happy with my purchase!",
    VeryPleased = "Very pleased!",
    VerySatisfied = "Very satisfied!",
    VeryUnhappyWithMyPurchase = "Very unhappy with my purchase!",
    WasteOfMoney = "Waste of money!",
    WouldBuyAgain = "Would buy again!",
    WouldNotBuyAgain = "Would not buy again!",
    WouldNotRecommend = "Would not recommend!",
}

export enum ShippingInformation {
    ShipsIn12BusinessDays = "Ships in 1-2 business days",
    ShipsIn1Month = "Ships in 1 month",
    ShipsIn1Week = "Ships in 1 week",
    ShipsIn2Weeks = "Ships in 2 weeks",
    ShipsIn35BusinessDays = "Ships in 3-5 business days",
    ShipsOvernight = "Ships overnight",
}

export enum WarrantyInformation {
    LifetimeWarranty = "Lifetime warranty",
    NoWarranty = "No warranty",
    The1MonthWarranty = "1 month warranty",
    The1WeekWarranty = "1 week warranty",
    The1YearWarranty = "1 year warranty",
    The2YearWarranty = "2 year warranty",
    The3MonthsWarranty = "3 months warranty",
    The3YearWarranty = "3 year warranty",
    The5YearWarranty = "5 year warranty",
    The6MonthsWarranty = "6 months warranty",
}

// Converts JSON strings to/from your types
export class Convert {
    public static toIProducts(json: string): IProducts {
        return JSON.parse(json);
    }

    public static iProductsToJson(value: IProducts): string {
        return JSON.stringify(value);
    }

    public static toDimensions(json: string): Dimensions {
        return JSON.parse(json);
    }

    public static dimensionsToJson(value: Dimensions): string {
        return JSON.stringify(value);
    }

    public static toMeta(json: string): Meta {
        return JSON.parse(json);
    }

    public static metaToJson(value: Meta): string {
        return JSON.stringify(value);
    }

    public static toReview(json: string): Review {
        return JSON.parse(json);
    }

    public static reviewToJson(value: Review): string {
        return JSON.stringify(value);
    }
}