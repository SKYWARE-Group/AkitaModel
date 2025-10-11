/**
 * Skyware.Lis.AkitaModel.Helpers
 */

// Type declarations for global objects
declare const Buffer: {
  from(data: string, encoding: string): {
    toString(encoding: string): string;
  };
} | undefined;

declare const btoa: ((data: string) => string) | undefined;
declare const atob: ((data: string) => string) | undefined;

/**
 * JSON and Base64 encoding helper.
 */
export class Base64Helper {
  /**
   * Serializes object as JSON and then return Base64 encoded string.
   * @param object Object to serialize
   * @returns Base64 encoded string
   */
  static getBase64Data(object: any): string {
    const json = JSON.stringify(object);
    
    // In browser environment
    if (typeof btoa !== 'undefined' && btoa) {
      return btoa(json);
    }
    
    // In Node.js environment
    if (typeof Buffer !== 'undefined' && Buffer) {
      return Buffer.from(json, 'utf-8').toString('base64');
    }
    
    // Fallback: manual base64 encoding
    return this.manualBase64Encode(json);
  }

  /**
   * Decodes Base64 string and parses JSON.
   * @param base64 Base64 encoded string
   * @returns Parsed object
   */
  static fromBase64Data<T>(base64: string): T {
    // In browser environment
    if (typeof atob !== 'undefined' && atob) {
      const json = atob(base64);
      return JSON.parse(json);
    }
    
    // In Node.js environment
    if (typeof Buffer !== 'undefined' && Buffer) {
      const json = Buffer.from(base64, 'base64').toString('utf-8');
      return JSON.parse(json);
    }
    
    // Fallback: manual base64 decoding
    const json = this.manualBase64Decode(base64);
    return JSON.parse(json);
  }

  /**
   * Manual Base64 encoding (fallback for environments without btoa/Buffer).
   */
  private static manualBase64Encode(str: string): string {
    const base64Chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/';
    let result = '';
    let i = 0;
    
    while (i < str.length) {
      const a = str.charCodeAt(i++);
      const b = i < str.length ? str.charCodeAt(i++) : 0;
      const c = i < str.length ? str.charCodeAt(i++) : 0;
      
      const bitmap = (a << 16) | (b << 8) | c;
      
      result += base64Chars.charAt((bitmap >> 18) & 63);
      result += base64Chars.charAt((bitmap >> 12) & 63);
      result += i - 2 < str.length ? base64Chars.charAt((bitmap >> 6) & 63) : '=';
      result += i - 1 < str.length ? base64Chars.charAt(bitmap & 63) : '=';
    }
    
    return result;
  }

  /**
   * Manual Base64 decoding (fallback for environments without atob/Buffer).
   */
  private static manualBase64Decode(base64: string): string {
    const base64Chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/';
    let result = '';
    let i = 0;
    
    base64 = base64.replace(/=+$/, '');
    
    while (i < base64.length) {
      const a = base64Chars.indexOf(base64.charAt(i++));
      const b = base64Chars.indexOf(base64.charAt(i++));
      const c = i < base64.length ? base64Chars.indexOf(base64.charAt(i++)) : -1;
      const d = i < base64.length ? base64Chars.indexOf(base64.charAt(i++)) : -1;
      
      const bitmap = (a << 18) | (b << 12) | ((c >= 0 ? c : 0) << 6) | (d >= 0 ? d : 0);
      
      result += String.fromCharCode((bitmap >> 16) & 255);
      if (c >= 0) result += String.fromCharCode((bitmap >> 8) & 255);
      if (d >= 0) result += String.fromCharCode(bitmap & 255);
    }
    
    return result;
  }
}
