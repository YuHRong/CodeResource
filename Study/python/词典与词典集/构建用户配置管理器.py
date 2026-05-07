def add_setting(settings_dict, key_value_pair):
    key, value = key_value_pair
    key = key.lower()
    value = value.lower()
    
    if key in settings_dict:
        return f"Setting '{key}' already exists! Cannot add a new setting with this name."
    else:
        settings_dict[key] = value
        return f"Setting '{key}' added with value '{value}' successfully!"

def update_setting(settings_dict, key_value_pair):
    key, value = key_value_pair
    key = key.lower()
    value = value.lower()
    
    if key in settings_dict:
        settings_dict[key] = value
        return f"Setting '{key}' updated to '{value}' successfully!"
    else:
        return f"Setting '{key}' does not exist! Cannot update a non-existing setting."

def delete_setting(settings_dict, key):
    key = key.lower()
    
    if key in settings_dict:
        del settings_dict[key]
        return f"Setting '{key}' deleted successfully!"
    else:
        return "Setting not found!"

def view_settings(settings_dict):
    if not settings_dict:
        return "No settings available."
    
    result = "Current User Settings:\n"
    for key, value in settings_dict.items():
        # Capitalize the first letter of the key
        formatted_key = key.capitalize()
        result += f"{formatted_key}: {value}\n"
    
    # Remove the trailing newline character
    return result.strip()

# Test the functions
test_settings = {}

# Test add_setting
print(add_setting(test_settings, ('Theme', 'Dark')))  # Should add successfully
print(add_setting(test_settings, ('theme', 'light')))  # Should fail (already exists)
print(add_setting(test_settings, ('Notifications', 'Enabled')))

# Test update_setting
print(update_setting(test_settings, ('Theme', 'Light')))  # Should update
print(update_setting(test_settings, ('Volume', 'High')))  # Should fail (doesn't exist)

# Test delete_setting
print(delete_setting(test_settings, ('notifications')))  # Should delete
print(delete_setting(test_settings, ('volume')))  # Should fail (doesn't exist)

# Test view_settings
print(view_settings(test_settings))  # Should show current settings
print(view_settings({}))  # Should show "No settings available"